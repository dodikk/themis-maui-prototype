﻿using System;
using System.IO;
using Com.Cossacklabs.Themis;

namespace Themis.Droid
{
    public class CellSealDroid: ICellSeal
    {
        public CellSealDroid(byte[] masterKeyData)
        {
            if (masterKeyData == null) throw new ArgumentNullException(nameof(masterKeyData));

            try
            {
                _secureCell = SecureCell.SealWithKey(masterKeyData);
            }
            catch (Exception ex)
            {
                throw new ThemisXamarinBridgeException(
                    message: "[FAIL] [droid] SecureCell java constructor failed",
                    dataAsHex: null,
                    contextAsHex: null,
                    dataAsBase64: null,
                    contextAsBase64: null,
                    inner: ex);
            }
        }

        public void Dispose()
        {
            try
            {
                if (_secureCell != null)
                {
                    _secureCell.Dispose();
                    _secureCell = null;
                }
            }
#pragma warning disable RECS0022 // A catch clause that catches System.Exception and has an empty body
            catch
            {
                // Suppressing.
                // A destructor must never throw
            }
#pragma warning restore RECS0022 // A catch clause that catches System.Exception and has an empty body
        }

        public byte[] UnwrapData(
            ISecureCellData cipherTextData,
            byte[] context = null)
        {
            if (cipherTextData == null) throw new ArgumentNullException(nameof(cipherTextData));

            byte[] cipherTextBytes;
            var managedCipherTextData = cipherTextData as SecureCellDataManaged;
            var droidCipherTextData = cipherTextData as SecureCellDataDroid;


            if (managedCipherTextData != null)
            {
                cipherTextBytes = managedCipherTextData.GetEncryptedData();
            }
            else if (droidCipherTextData != null)
            {
                cipherTextBytes = droidCipherTextData.GetEncryptedData();
            }
            else
            {
                throw new ArgumentException(
                    message: $"Type mismatch: {cipherTextData.GetType()} received. Expected: [ {typeof(SecureCellDataDroid)} ; {typeof(SecureCellDataManaged)} ] ",
                    paramName: nameof(cipherTextData));
            }


            try
            {
                byte[] result = _secureCell.Decrypt(cipherTextBytes, context);

                return result;
            }
            catch (Exception ex)
            {
                throw new ThemisXamarinBridgeException(
                    message: "[FAIL] [droid] SecureCell.Unprotect() java method failed",
                    dataAsHex: ConvertUtilsPortable.ByteArrayToHexString(cipherTextBytes),
                    contextAsHex: ConvertUtilsPortable.ByteArrayToHexString(context),
                    dataAsBase64: Convert.ToBase64String(cipherTextBytes),
                    contextAsBase64: Convert.ToBase64String(context),
                    inner: ex);
            }
        }

        public ISecureCellData WrapData(
            byte[] plainTextData,
            byte[] context = null)
        {
            if (plainTextData == null) throw new ArgumentNullException(nameof(plainTextData));

            try
            {
                byte[] cipherText = _secureCell.Encrypt(plainTextData, context);

                var result = new SecureCellDataManaged(cipherText);

                return result;
            }
            catch (Exception ex)
            {
                throw new ThemisXamarinBridgeException(
                    message: "[FAIL] [droid] SecureCell.Protect() java method failed",
                    dataAsHex: null, // avoid leaking plain text in logs
                    contextAsHex: ConvertUtilsPortable.ByteArrayToHexString(context), // seems ok to log context
                    dataAsBase64: null, // avoid leaking plain text in logs
                    contextAsBase64: Convert.ToBase64String(context),
                    inner: ex);
            }
        }

        public ISecureCellData WrapDataStream(
            Stream plainTextStream,
            Stream contextStream = null)
        {
            if (plainTextStream == null) throw new ArgumentNullException(nameof(plainTextStream));

            byte[] plainTextBytes = ConvertUtilsPortable.StreamToByteArray(plainTextStream);
            byte[] contextBytes = ConvertUtilsPortable.StreamToByteArray(contextStream);

            var result = WrapData(plainTextBytes, context: contextBytes);

            return result;
        }

        public Stream UnwrapDataAsStream(
            ISecureCellData cipherTextData,
            Stream contextStream = null)
        {
            if (cipherTextData == null) throw new ArgumentNullException(nameof(cipherTextData));

            byte[] contextBytes = ConvertUtilsPortable.StreamToByteArray(contextStream);
            byte[] resultBytes = UnwrapData(cipherTextData, context: contextBytes);

            var result = ConvertUtilsPortable.ByteArrayToMemoryStream(resultBytes);

            return result;
        }

        private SecureCell.ISeal _secureCell;
    }
}

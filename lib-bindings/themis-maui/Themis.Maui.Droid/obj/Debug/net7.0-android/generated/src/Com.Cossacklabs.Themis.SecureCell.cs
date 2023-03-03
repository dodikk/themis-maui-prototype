using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Cossacklabs.Themis {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.cossacklabs.themis']/class[@name='SecureCell']"
	[global::Android.Runtime.Register ("com/cossacklabs/themis/SecureCell", DoNotGenerateAcw=true)]
	public partial class SecureCell : global::Java.Lang.Object {
		// Metadata.xml XPath field reference: path="/api/package[@name='com.cossacklabs.themis']/class[@name='SecureCell']/field[@name='MODE_CONTEXT_IMPRINT']"
		[Register ("MODE_CONTEXT_IMPRINT")]
		[global::System.Obsolete (@"deprecated")]
		public const int ModeContextImprint = (int) 2;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.cossacklabs.themis']/class[@name='SecureCell']/field[@name='MODE_SEAL']"
		[Register ("MODE_SEAL")]
		[global::System.Obsolete (@"deprecated")]
		public const int ModeSeal = (int) 0;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.cossacklabs.themis']/class[@name='SecureCell']/field[@name='MODE_TOKEN_PROTECT']"
		[Register ("MODE_TOKEN_PROTECT")]
		[global::System.Obsolete (@"deprecated")]
		public const int ModeTokenProtect = (int) 1;

		// Metadata.xml XPath interface reference: path="/api/package[@name='com.cossacklabs.themis']/interface[@name='SecureCell.ContextImprint']"
		[Register ("com/cossacklabs/themis/SecureCell$ContextImprint", "", "Com.Cossacklabs.Themis.SecureCell/IContextImprintInvoker")]
		public partial interface IContextImprint : IJavaObject, IJavaPeerable {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.cossacklabs.themis']/interface[@name='SecureCell.ContextImprint']/method[@name='decrypt' and count(parameter)=2 and parameter[1][@type='byte[]'] and parameter[2][@type='byte[]']]"
			[Register ("decrypt", "([B[B)[B", "GetDecrypt_arrayBarrayBHandler:Com.Cossacklabs.Themis.SecureCell/IContextImprintInvoker, Themis.Maui.Droid")]
			byte[] Decrypt (byte[]? p0, byte[]? p1);

			// Metadata.xml XPath method reference: path="/api/package[@name='com.cossacklabs.themis']/interface[@name='SecureCell.ContextImprint']/method[@name='encrypt' and count(parameter)=2 and parameter[1][@type='byte[]'] and parameter[2][@type='byte[]']]"
			[Register ("encrypt", "([B[B)[B", "GetEncrypt_arrayBarrayBHandler:Com.Cossacklabs.Themis.SecureCell/IContextImprintInvoker, Themis.Maui.Droid")]
			byte[] Encrypt (byte[]? p0, byte[]? p1);

		}

		[global::Android.Runtime.Register ("com/cossacklabs/themis/SecureCell$ContextImprint", DoNotGenerateAcw=true)]
		internal partial class IContextImprintInvoker : global::Java.Lang.Object, IContextImprint {
			static readonly JniPeerMembers _members = new XAPeerMembers ("com/cossacklabs/themis/SecureCell$ContextImprint", typeof (IContextImprintInvoker));

			static IntPtr java_class_ref {
				get { return _members.JniPeerType.PeerReference.Handle; }
			}

			[global::System.Diagnostics.DebuggerBrowsable (global::System.Diagnostics.DebuggerBrowsableState.Never)]
			[global::System.ComponentModel.EditorBrowsable (global::System.ComponentModel.EditorBrowsableState.Never)]
			public override global::Java.Interop.JniPeerMembers JniPeerMembers {
				get { return _members; }
			}

			[global::System.Diagnostics.DebuggerBrowsable (global::System.Diagnostics.DebuggerBrowsableState.Never)]
			[global::System.ComponentModel.EditorBrowsable (global::System.ComponentModel.EditorBrowsableState.Never)]
			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			[global::System.Diagnostics.DebuggerBrowsable (global::System.Diagnostics.DebuggerBrowsableState.Never)]
			[global::System.ComponentModel.EditorBrowsable (global::System.ComponentModel.EditorBrowsableState.Never)]
			protected override global::System.Type ThresholdType {
				get { return _members.ManagedPeerType; }
			}

			IntPtr class_ref;

			public static IContextImprint? GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IContextImprint> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'com.cossacklabs.themis.SecureCell.ContextImprint'.");
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IContextImprintInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate? cb_decrypt_arrayBarrayB;
#pragma warning disable 0169
			static Delegate GetDecrypt_arrayBarrayBHandler ()
			{
				if (cb_decrypt_arrayBarrayB == null)
					cb_decrypt_arrayBarrayB = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_L) n_Decrypt_arrayBarrayB);
				return cb_decrypt_arrayBarrayB;
			}

			static IntPtr n_Decrypt_arrayBarrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Cossacklabs.Themis.SecureCell.IContextImprint> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var p0 = (byte[]?) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (byte));
				var p1 = (byte[]?) JNIEnv.GetArray (native_p1, JniHandleOwnership.DoNotTransfer, typeof (byte));
				IntPtr __ret = JNIEnv.NewArray (__this.Decrypt (p0, p1));
				if (p0 != null)
					JNIEnv.CopyArray (p0, native_p0);
				if (p1 != null)
					JNIEnv.CopyArray (p1, native_p1);
				return __ret;
			}
#pragma warning restore 0169

			IntPtr id_decrypt_arrayBarrayB;
			public unsafe byte[] Decrypt (byte[]? p0, byte[]? p1)
			{
				if (id_decrypt_arrayBarrayB == IntPtr.Zero)
					id_decrypt_arrayBarrayB = JNIEnv.GetMethodID (class_ref, "decrypt", "([B[B)[B");
				IntPtr native_p0 = JNIEnv.NewArray (p0);
				IntPtr native_p1 = JNIEnv.NewArray (p1);
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				var __ret = (byte[]?) JNIEnv.GetArray (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_decrypt_arrayBarrayB, __args), JniHandleOwnership.TransferLocalRef, typeof (byte))!;
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
				if (p1 != null) {
					JNIEnv.CopyArray (native_p1, p1);
					JNIEnv.DeleteLocalRef (native_p1);
				}
				return __ret;
			}

			static Delegate? cb_encrypt_arrayBarrayB;
#pragma warning disable 0169
			static Delegate GetEncrypt_arrayBarrayBHandler ()
			{
				if (cb_encrypt_arrayBarrayB == null)
					cb_encrypt_arrayBarrayB = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_L) n_Encrypt_arrayBarrayB);
				return cb_encrypt_arrayBarrayB;
			}

			static IntPtr n_Encrypt_arrayBarrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Cossacklabs.Themis.SecureCell.IContextImprint> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var p0 = (byte[]?) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (byte));
				var p1 = (byte[]?) JNIEnv.GetArray (native_p1, JniHandleOwnership.DoNotTransfer, typeof (byte));
				IntPtr __ret = JNIEnv.NewArray (__this.Encrypt (p0, p1));
				if (p0 != null)
					JNIEnv.CopyArray (p0, native_p0);
				if (p1 != null)
					JNIEnv.CopyArray (p1, native_p1);
				return __ret;
			}
#pragma warning restore 0169

			IntPtr id_encrypt_arrayBarrayB;
			public unsafe byte[] Encrypt (byte[]? p0, byte[]? p1)
			{
				if (id_encrypt_arrayBarrayB == IntPtr.Zero)
					id_encrypt_arrayBarrayB = JNIEnv.GetMethodID (class_ref, "encrypt", "([B[B)[B");
				IntPtr native_p0 = JNIEnv.NewArray (p0);
				IntPtr native_p1 = JNIEnv.NewArray (p1);
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				var __ret = (byte[]?) JNIEnv.GetArray (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_encrypt_arrayBarrayB, __args), JniHandleOwnership.TransferLocalRef, typeof (byte))!;
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
				if (p1 != null) {
					JNIEnv.CopyArray (native_p1, p1);
					JNIEnv.DeleteLocalRef (native_p1);
				}
				return __ret;
			}

		}

		// Metadata.xml XPath interface reference: path="/api/package[@name='com.cossacklabs.themis']/interface[@name='SecureCell.Seal']"
		[Register ("com/cossacklabs/themis/SecureCell$Seal", "", "Com.Cossacklabs.Themis.SecureCell/ISealInvoker")]
		public partial interface ISeal : IJavaObject, IJavaPeerable {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.cossacklabs.themis']/interface[@name='SecureCell.Seal']/method[@name='decrypt' and count(parameter)=1 and parameter[1][@type='byte[]']]"
			[Register ("decrypt", "([B)[B", "GetDecrypt_arrayBHandler:Com.Cossacklabs.Themis.SecureCell/ISealInvoker, Themis.Maui.Droid")]
			byte[] Decrypt (byte[]? p0);

			// Metadata.xml XPath method reference: path="/api/package[@name='com.cossacklabs.themis']/interface[@name='SecureCell.Seal']/method[@name='decrypt' and count(parameter)=2 and parameter[1][@type='byte[]'] and parameter[2][@type='byte[]']]"
			[Register ("decrypt", "([B[B)[B", "GetDecrypt_arrayBarrayBHandler:Com.Cossacklabs.Themis.SecureCell/ISealInvoker, Themis.Maui.Droid")]
			byte[] Decrypt (byte[]? p0, byte[]? p1);

			// Metadata.xml XPath method reference: path="/api/package[@name='com.cossacklabs.themis']/interface[@name='SecureCell.Seal']/method[@name='encrypt' and count(parameter)=1 and parameter[1][@type='byte[]']]"
			[Register ("encrypt", "([B)[B", "GetEncrypt_arrayBHandler:Com.Cossacklabs.Themis.SecureCell/ISealInvoker, Themis.Maui.Droid")]
			byte[] Encrypt (byte[]? p0);

			// Metadata.xml XPath method reference: path="/api/package[@name='com.cossacklabs.themis']/interface[@name='SecureCell.Seal']/method[@name='encrypt' and count(parameter)=2 and parameter[1][@type='byte[]'] and parameter[2][@type='byte[]']]"
			[Register ("encrypt", "([B[B)[B", "GetEncrypt_arrayBarrayBHandler:Com.Cossacklabs.Themis.SecureCell/ISealInvoker, Themis.Maui.Droid")]
			byte[] Encrypt (byte[]? p0, byte[]? p1);

		}

		[global::Android.Runtime.Register ("com/cossacklabs/themis/SecureCell$Seal", DoNotGenerateAcw=true)]
		internal partial class ISealInvoker : global::Java.Lang.Object, ISeal {
			static readonly JniPeerMembers _members = new XAPeerMembers ("com/cossacklabs/themis/SecureCell$Seal", typeof (ISealInvoker));

			static IntPtr java_class_ref {
				get { return _members.JniPeerType.PeerReference.Handle; }
			}

			[global::System.Diagnostics.DebuggerBrowsable (global::System.Diagnostics.DebuggerBrowsableState.Never)]
			[global::System.ComponentModel.EditorBrowsable (global::System.ComponentModel.EditorBrowsableState.Never)]
			public override global::Java.Interop.JniPeerMembers JniPeerMembers {
				get { return _members; }
			}

			[global::System.Diagnostics.DebuggerBrowsable (global::System.Diagnostics.DebuggerBrowsableState.Never)]
			[global::System.ComponentModel.EditorBrowsable (global::System.ComponentModel.EditorBrowsableState.Never)]
			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			[global::System.Diagnostics.DebuggerBrowsable (global::System.Diagnostics.DebuggerBrowsableState.Never)]
			[global::System.ComponentModel.EditorBrowsable (global::System.ComponentModel.EditorBrowsableState.Never)]
			protected override global::System.Type ThresholdType {
				get { return _members.ManagedPeerType; }
			}

			IntPtr class_ref;

			public static ISeal? GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<ISeal> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'com.cossacklabs.themis.SecureCell.Seal'.");
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public ISealInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate? cb_decrypt_arrayB;
#pragma warning disable 0169
			static Delegate GetDecrypt_arrayBHandler ()
			{
				if (cb_decrypt_arrayB == null)
					cb_decrypt_arrayB = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_Decrypt_arrayB);
				return cb_decrypt_arrayB;
			}

			static IntPtr n_Decrypt_arrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Cossacklabs.Themis.SecureCell.ISeal> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var p0 = (byte[]?) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (byte));
				IntPtr __ret = JNIEnv.NewArray (__this.Decrypt (p0));
				if (p0 != null)
					JNIEnv.CopyArray (p0, native_p0);
				return __ret;
			}
#pragma warning restore 0169

			IntPtr id_decrypt_arrayB;
			public unsafe byte[] Decrypt (byte[]? p0)
			{
				if (id_decrypt_arrayB == IntPtr.Zero)
					id_decrypt_arrayB = JNIEnv.GetMethodID (class_ref, "decrypt", "([B)[B");
				IntPtr native_p0 = JNIEnv.NewArray (p0);
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				var __ret = (byte[]?) JNIEnv.GetArray (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_decrypt_arrayB, __args), JniHandleOwnership.TransferLocalRef, typeof (byte))!;
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
				return __ret;
			}

			static Delegate? cb_decrypt_arrayBarrayB;
#pragma warning disable 0169
			static Delegate GetDecrypt_arrayBarrayBHandler ()
			{
				if (cb_decrypt_arrayBarrayB == null)
					cb_decrypt_arrayBarrayB = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_L) n_Decrypt_arrayBarrayB);
				return cb_decrypt_arrayBarrayB;
			}

			static IntPtr n_Decrypt_arrayBarrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Cossacklabs.Themis.SecureCell.ISeal> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var p0 = (byte[]?) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (byte));
				var p1 = (byte[]?) JNIEnv.GetArray (native_p1, JniHandleOwnership.DoNotTransfer, typeof (byte));
				IntPtr __ret = JNIEnv.NewArray (__this.Decrypt (p0, p1));
				if (p0 != null)
					JNIEnv.CopyArray (p0, native_p0);
				if (p1 != null)
					JNIEnv.CopyArray (p1, native_p1);
				return __ret;
			}
#pragma warning restore 0169

			IntPtr id_decrypt_arrayBarrayB;
			public unsafe byte[] Decrypt (byte[]? p0, byte[]? p1)
			{
				if (id_decrypt_arrayBarrayB == IntPtr.Zero)
					id_decrypt_arrayBarrayB = JNIEnv.GetMethodID (class_ref, "decrypt", "([B[B)[B");
				IntPtr native_p0 = JNIEnv.NewArray (p0);
				IntPtr native_p1 = JNIEnv.NewArray (p1);
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				var __ret = (byte[]?) JNIEnv.GetArray (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_decrypt_arrayBarrayB, __args), JniHandleOwnership.TransferLocalRef, typeof (byte))!;
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
				if (p1 != null) {
					JNIEnv.CopyArray (native_p1, p1);
					JNIEnv.DeleteLocalRef (native_p1);
				}
				return __ret;
			}

			static Delegate? cb_encrypt_arrayB;
#pragma warning disable 0169
			static Delegate GetEncrypt_arrayBHandler ()
			{
				if (cb_encrypt_arrayB == null)
					cb_encrypt_arrayB = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_Encrypt_arrayB);
				return cb_encrypt_arrayB;
			}

			static IntPtr n_Encrypt_arrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Cossacklabs.Themis.SecureCell.ISeal> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var p0 = (byte[]?) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (byte));
				IntPtr __ret = JNIEnv.NewArray (__this.Encrypt (p0));
				if (p0 != null)
					JNIEnv.CopyArray (p0, native_p0);
				return __ret;
			}
#pragma warning restore 0169

			IntPtr id_encrypt_arrayB;
			public unsafe byte[] Encrypt (byte[]? p0)
			{
				if (id_encrypt_arrayB == IntPtr.Zero)
					id_encrypt_arrayB = JNIEnv.GetMethodID (class_ref, "encrypt", "([B)[B");
				IntPtr native_p0 = JNIEnv.NewArray (p0);
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				var __ret = (byte[]?) JNIEnv.GetArray (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_encrypt_arrayB, __args), JniHandleOwnership.TransferLocalRef, typeof (byte))!;
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
				return __ret;
			}

			static Delegate? cb_encrypt_arrayBarrayB;
#pragma warning disable 0169
			static Delegate GetEncrypt_arrayBarrayBHandler ()
			{
				if (cb_encrypt_arrayBarrayB == null)
					cb_encrypt_arrayBarrayB = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_L) n_Encrypt_arrayBarrayB);
				return cb_encrypt_arrayBarrayB;
			}

			static IntPtr n_Encrypt_arrayBarrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Cossacklabs.Themis.SecureCell.ISeal> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var p0 = (byte[]?) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (byte));
				var p1 = (byte[]?) JNIEnv.GetArray (native_p1, JniHandleOwnership.DoNotTransfer, typeof (byte));
				IntPtr __ret = JNIEnv.NewArray (__this.Encrypt (p0, p1));
				if (p0 != null)
					JNIEnv.CopyArray (p0, native_p0);
				if (p1 != null)
					JNIEnv.CopyArray (p1, native_p1);
				return __ret;
			}
#pragma warning restore 0169

			IntPtr id_encrypt_arrayBarrayB;
			public unsafe byte[] Encrypt (byte[]? p0, byte[]? p1)
			{
				if (id_encrypt_arrayBarrayB == IntPtr.Zero)
					id_encrypt_arrayBarrayB = JNIEnv.GetMethodID (class_ref, "encrypt", "([B[B)[B");
				IntPtr native_p0 = JNIEnv.NewArray (p0);
				IntPtr native_p1 = JNIEnv.NewArray (p1);
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				var __ret = (byte[]?) JNIEnv.GetArray (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_encrypt_arrayBarrayB, __args), JniHandleOwnership.TransferLocalRef, typeof (byte))!;
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
				if (p1 != null) {
					JNIEnv.CopyArray (native_p1, p1);
					JNIEnv.DeleteLocalRef (native_p1);
				}
				return __ret;
			}

		}

		// Metadata.xml XPath interface reference: path="/api/package[@name='com.cossacklabs.themis']/interface[@name='SecureCell.TokenProtect']"
		[Register ("com/cossacklabs/themis/SecureCell$TokenProtect", "", "Com.Cossacklabs.Themis.SecureCell/ITokenProtectInvoker")]
		public partial interface ITokenProtect : IJavaObject, IJavaPeerable {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.cossacklabs.themis']/interface[@name='SecureCell.TokenProtect']/method[@name='decrypt' and count(parameter)=2 and parameter[1][@type='byte[]'] and parameter[2][@type='byte[]']]"
			[Register ("decrypt", "([B[B)[B", "GetDecrypt_arrayBarrayBHandler:Com.Cossacklabs.Themis.SecureCell/ITokenProtectInvoker, Themis.Maui.Droid")]
			byte[] Decrypt (byte[]? p0, byte[]? p1);

			// Metadata.xml XPath method reference: path="/api/package[@name='com.cossacklabs.themis']/interface[@name='SecureCell.TokenProtect']/method[@name='decrypt' and count(parameter)=3 and parameter[1][@type='byte[]'] and parameter[2][@type='byte[]'] and parameter[3][@type='byte[]']]"
			[Register ("decrypt", "([B[B[B)[B", "GetDecrypt_arrayBarrayBarrayBHandler:Com.Cossacklabs.Themis.SecureCell/ITokenProtectInvoker, Themis.Maui.Droid")]
			byte[] Decrypt (byte[]? p0, byte[]? p1, byte[]? p2);

			// Metadata.xml XPath method reference: path="/api/package[@name='com.cossacklabs.themis']/interface[@name='SecureCell.TokenProtect']/method[@name='encrypt' and count(parameter)=1 and parameter[1][@type='byte[]']]"
			[Register ("encrypt", "([B)Lcom/cossacklabs/themis/SecureCellData;", "GetEncrypt_arrayBHandler:Com.Cossacklabs.Themis.SecureCell/ITokenProtectInvoker, Themis.Maui.Droid")]
			global::Com.Cossacklabs.Themis.SecureCellData Encrypt (byte[]? p0);

			// Metadata.xml XPath method reference: path="/api/package[@name='com.cossacklabs.themis']/interface[@name='SecureCell.TokenProtect']/method[@name='encrypt' and count(parameter)=2 and parameter[1][@type='byte[]'] and parameter[2][@type='byte[]']]"
			[Register ("encrypt", "([B[B)Lcom/cossacklabs/themis/SecureCellData;", "GetEncrypt_arrayBarrayBHandler:Com.Cossacklabs.Themis.SecureCell/ITokenProtectInvoker, Themis.Maui.Droid")]
			global::Com.Cossacklabs.Themis.SecureCellData Encrypt (byte[]? p0, byte[]? p1);

		}

		[global::Android.Runtime.Register ("com/cossacklabs/themis/SecureCell$TokenProtect", DoNotGenerateAcw=true)]
		internal partial class ITokenProtectInvoker : global::Java.Lang.Object, ITokenProtect {
			static readonly JniPeerMembers _members = new XAPeerMembers ("com/cossacklabs/themis/SecureCell$TokenProtect", typeof (ITokenProtectInvoker));

			static IntPtr java_class_ref {
				get { return _members.JniPeerType.PeerReference.Handle; }
			}

			[global::System.Diagnostics.DebuggerBrowsable (global::System.Diagnostics.DebuggerBrowsableState.Never)]
			[global::System.ComponentModel.EditorBrowsable (global::System.ComponentModel.EditorBrowsableState.Never)]
			public override global::Java.Interop.JniPeerMembers JniPeerMembers {
				get { return _members; }
			}

			[global::System.Diagnostics.DebuggerBrowsable (global::System.Diagnostics.DebuggerBrowsableState.Never)]
			[global::System.ComponentModel.EditorBrowsable (global::System.ComponentModel.EditorBrowsableState.Never)]
			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			[global::System.Diagnostics.DebuggerBrowsable (global::System.Diagnostics.DebuggerBrowsableState.Never)]
			[global::System.ComponentModel.EditorBrowsable (global::System.ComponentModel.EditorBrowsableState.Never)]
			protected override global::System.Type ThresholdType {
				get { return _members.ManagedPeerType; }
			}

			IntPtr class_ref;

			public static ITokenProtect? GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<ITokenProtect> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'com.cossacklabs.themis.SecureCell.TokenProtect'.");
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public ITokenProtectInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate? cb_decrypt_arrayBarrayB;
#pragma warning disable 0169
			static Delegate GetDecrypt_arrayBarrayBHandler ()
			{
				if (cb_decrypt_arrayBarrayB == null)
					cb_decrypt_arrayBarrayB = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_L) n_Decrypt_arrayBarrayB);
				return cb_decrypt_arrayBarrayB;
			}

			static IntPtr n_Decrypt_arrayBarrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Cossacklabs.Themis.SecureCell.ITokenProtect> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var p0 = (byte[]?) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (byte));
				var p1 = (byte[]?) JNIEnv.GetArray (native_p1, JniHandleOwnership.DoNotTransfer, typeof (byte));
				IntPtr __ret = JNIEnv.NewArray (__this.Decrypt (p0, p1));
				if (p0 != null)
					JNIEnv.CopyArray (p0, native_p0);
				if (p1 != null)
					JNIEnv.CopyArray (p1, native_p1);
				return __ret;
			}
#pragma warning restore 0169

			IntPtr id_decrypt_arrayBarrayB;
			public unsafe byte[] Decrypt (byte[]? p0, byte[]? p1)
			{
				if (id_decrypt_arrayBarrayB == IntPtr.Zero)
					id_decrypt_arrayBarrayB = JNIEnv.GetMethodID (class_ref, "decrypt", "([B[B)[B");
				IntPtr native_p0 = JNIEnv.NewArray (p0);
				IntPtr native_p1 = JNIEnv.NewArray (p1);
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				var __ret = (byte[]?) JNIEnv.GetArray (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_decrypt_arrayBarrayB, __args), JniHandleOwnership.TransferLocalRef, typeof (byte))!;
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
				if (p1 != null) {
					JNIEnv.CopyArray (native_p1, p1);
					JNIEnv.DeleteLocalRef (native_p1);
				}
				return __ret;
			}

			static Delegate? cb_decrypt_arrayBarrayBarrayB;
#pragma warning disable 0169
			static Delegate GetDecrypt_arrayBarrayBarrayBHandler ()
			{
				if (cb_decrypt_arrayBarrayBarrayB == null)
					cb_decrypt_arrayBarrayBarrayB = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLL_L) n_Decrypt_arrayBarrayBarrayB);
				return cb_decrypt_arrayBarrayBarrayB;
			}

			static IntPtr n_Decrypt_arrayBarrayBarrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Cossacklabs.Themis.SecureCell.ITokenProtect> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var p0 = (byte[]?) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (byte));
				var p1 = (byte[]?) JNIEnv.GetArray (native_p1, JniHandleOwnership.DoNotTransfer, typeof (byte));
				var p2 = (byte[]?) JNIEnv.GetArray (native_p2, JniHandleOwnership.DoNotTransfer, typeof (byte));
				IntPtr __ret = JNIEnv.NewArray (__this.Decrypt (p0, p1, p2));
				if (p0 != null)
					JNIEnv.CopyArray (p0, native_p0);
				if (p1 != null)
					JNIEnv.CopyArray (p1, native_p1);
				if (p2 != null)
					JNIEnv.CopyArray (p2, native_p2);
				return __ret;
			}
#pragma warning restore 0169

			IntPtr id_decrypt_arrayBarrayBarrayB;
			public unsafe byte[] Decrypt (byte[]? p0, byte[]? p1, byte[]? p2)
			{
				if (id_decrypt_arrayBarrayBarrayB == IntPtr.Zero)
					id_decrypt_arrayBarrayBarrayB = JNIEnv.GetMethodID (class_ref, "decrypt", "([B[B[B)[B");
				IntPtr native_p0 = JNIEnv.NewArray (p0);
				IntPtr native_p1 = JNIEnv.NewArray (p1);
				IntPtr native_p2 = JNIEnv.NewArray (p2);
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (native_p2);
				var __ret = (byte[]?) JNIEnv.GetArray (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_decrypt_arrayBarrayBarrayB, __args), JniHandleOwnership.TransferLocalRef, typeof (byte))!;
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
				if (p1 != null) {
					JNIEnv.CopyArray (native_p1, p1);
					JNIEnv.DeleteLocalRef (native_p1);
				}
				if (p2 != null) {
					JNIEnv.CopyArray (native_p2, p2);
					JNIEnv.DeleteLocalRef (native_p2);
				}
				return __ret;
			}

			static Delegate? cb_encrypt_arrayB;
#pragma warning disable 0169
			static Delegate GetEncrypt_arrayBHandler ()
			{
				if (cb_encrypt_arrayB == null)
					cb_encrypt_arrayB = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_Encrypt_arrayB);
				return cb_encrypt_arrayB;
			}

			static IntPtr n_Encrypt_arrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Cossacklabs.Themis.SecureCell.ITokenProtect> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var p0 = (byte[]?) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (byte));
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Encrypt (p0));
				if (p0 != null)
					JNIEnv.CopyArray (p0, native_p0);
				return __ret;
			}
#pragma warning restore 0169

			IntPtr id_encrypt_arrayB;
			public unsafe global::Com.Cossacklabs.Themis.SecureCellData Encrypt (byte[]? p0)
			{
				if (id_encrypt_arrayB == IntPtr.Zero)
					id_encrypt_arrayB = JNIEnv.GetMethodID (class_ref, "encrypt", "([B)Lcom/cossacklabs/themis/SecureCellData;");
				IntPtr native_p0 = JNIEnv.NewArray (p0);
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				var __ret = global::Java.Lang.Object.GetObject<global::Com.Cossacklabs.Themis.SecureCellData> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_encrypt_arrayB, __args), JniHandleOwnership.TransferLocalRef)!;
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
				return __ret;
			}

			static Delegate? cb_encrypt_arrayBarrayB;
#pragma warning disable 0169
			static Delegate GetEncrypt_arrayBarrayBHandler ()
			{
				if (cb_encrypt_arrayBarrayB == null)
					cb_encrypt_arrayBarrayB = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_L) n_Encrypt_arrayBarrayB);
				return cb_encrypt_arrayBarrayB;
			}

			static IntPtr n_Encrypt_arrayBarrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Cossacklabs.Themis.SecureCell.ITokenProtect> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var p0 = (byte[]?) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (byte));
				var p1 = (byte[]?) JNIEnv.GetArray (native_p1, JniHandleOwnership.DoNotTransfer, typeof (byte));
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Encrypt (p0, p1));
				if (p0 != null)
					JNIEnv.CopyArray (p0, native_p0);
				if (p1 != null)
					JNIEnv.CopyArray (p1, native_p1);
				return __ret;
			}
#pragma warning restore 0169

			IntPtr id_encrypt_arrayBarrayB;
			public unsafe global::Com.Cossacklabs.Themis.SecureCellData Encrypt (byte[]? p0, byte[]? p1)
			{
				if (id_encrypt_arrayBarrayB == IntPtr.Zero)
					id_encrypt_arrayBarrayB = JNIEnv.GetMethodID (class_ref, "encrypt", "([B[B)Lcom/cossacklabs/themis/SecureCellData;");
				IntPtr native_p0 = JNIEnv.NewArray (p0);
				IntPtr native_p1 = JNIEnv.NewArray (p1);
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				var __ret = global::Java.Lang.Object.GetObject<global::Com.Cossacklabs.Themis.SecureCellData> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_encrypt_arrayBarrayB, __args), JniHandleOwnership.TransferLocalRef)!;
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
				if (p1 != null) {
					JNIEnv.CopyArray (native_p1, p1);
					JNIEnv.DeleteLocalRef (native_p1);
				}
				return __ret;
			}

		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/cossacklabs/themis/SecureCell", typeof (SecureCell));

		internal static IntPtr class_ref {
			get { return _members.JniPeerType.PeerReference.Handle; }
		}

		[global::System.Diagnostics.DebuggerBrowsable (global::System.Diagnostics.DebuggerBrowsableState.Never)]
		[global::System.ComponentModel.EditorBrowsable (global::System.ComponentModel.EditorBrowsableState.Never)]
		public override global::Java.Interop.JniPeerMembers JniPeerMembers {
			get { return _members; }
		}

		[global::System.Diagnostics.DebuggerBrowsable (global::System.Diagnostics.DebuggerBrowsableState.Never)]
		[global::System.ComponentModel.EditorBrowsable (global::System.ComponentModel.EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass {
			get { return _members.JniPeerType.PeerReference.Handle; }
		}

		[global::System.Diagnostics.DebuggerBrowsable (global::System.Diagnostics.DebuggerBrowsableState.Never)]
		[global::System.ComponentModel.EditorBrowsable (global::System.ComponentModel.EditorBrowsableState.Never)]
		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

		protected SecureCell (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.cossacklabs.themis']/class[@name='SecureCell']/constructor[@name='SecureCell' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register (".ctor", "([B)V", "")]
		[global::System.Obsolete (@"deprecated")]
		public unsafe SecureCell (byte[]? key) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "([B)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_key = JNIEnv.NewArray (key);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_key);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				if (key != null) {
					JNIEnv.CopyArray (native_key, key);
					JNIEnv.DeleteLocalRef (native_key);
				}
				global::System.GC.KeepAlive (key);
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.cossacklabs.themis']/class[@name='SecureCell']/constructor[@name='SecureCell' and count(parameter)=2 and parameter[1][@type='byte[]'] and parameter[2][@type='int']]"
		[Register (".ctor", "([BI)V", "")]
		[global::System.Obsolete (@"deprecated")]
		public unsafe SecureCell (byte[]? key, int mode) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "([BI)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_key = JNIEnv.NewArray (key);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_key);
				__args [1] = new JniArgumentValue (mode);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				if (key != null) {
					JNIEnv.CopyArray (native_key, key);
					JNIEnv.DeleteLocalRef (native_key);
				}
				global::System.GC.KeepAlive (key);
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.cossacklabs.themis']/class[@name='SecureCell']/constructor[@name='SecureCell' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register (".ctor", "(I)V", "")]
		[global::System.Obsolete (@"deprecated")]
		public unsafe SecureCell (int mode) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(I)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (mode);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.cossacklabs.themis']/class[@name='SecureCell']/constructor[@name='SecureCell' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register (".ctor", "(Ljava/lang/String;)V", "")]
		[global::System.Obsolete (@"deprecated")]
		public unsafe SecureCell (string? password) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/lang/String;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_password = JNIEnv.NewString ((string?)password);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_password);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_password);
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.cossacklabs.themis']/class[@name='SecureCell']/constructor[@name='SecureCell' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int']]"
		[Register (".ctor", "(Ljava/lang/String;I)V", "")]
		[global::System.Obsolete (@"deprecated")]
		public unsafe SecureCell (string? password, int mode) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/lang/String;I)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_password = JNIEnv.NewString ((string?)password);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_password);
				__args [1] = new JniArgumentValue (mode);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_password);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.cossacklabs.themis']/class[@name='SecureCell']/method[@name='ContextImprintWithKey' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("ContextImprintWithKey", "([B)Lcom/cossacklabs/themis/SecureCell$ContextImprint;", "")]
		public static unsafe global::Com.Cossacklabs.Themis.SecureCell.IContextImprint ContextImprintWithKey (byte[]? key)
		{
			const string __id = "ContextImprintWithKey.([B)Lcom/cossacklabs/themis/SecureCell$ContextImprint;";
			IntPtr native_key = JNIEnv.NewArray (key);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_key);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Cossacklabs.Themis.SecureCell.IContextImprint> (__rm.Handle, JniHandleOwnership.TransferLocalRef)!;
			} finally {
				if (key != null) {
					JNIEnv.CopyArray (native_key, key);
					JNIEnv.DeleteLocalRef (native_key);
				}
				global::System.GC.KeepAlive (key);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.cossacklabs.themis']/class[@name='SecureCell']/method[@name='ContextImprintWithKey' and count(parameter)=1 and parameter[1][@type='com.cossacklabs.themis.SymmetricKey']]"
		[Register ("ContextImprintWithKey", "(Lcom/cossacklabs/themis/SymmetricKey;)Lcom/cossacklabs/themis/SecureCell$ContextImprint;", "")]
		public static unsafe global::Com.Cossacklabs.Themis.SecureCell.IContextImprint ContextImprintWithKey (global::Com.Cossacklabs.Themis.SymmetricKey? key)
		{
			const string __id = "ContextImprintWithKey.(Lcom/cossacklabs/themis/SymmetricKey;)Lcom/cossacklabs/themis/SecureCell$ContextImprint;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((key == null) ? IntPtr.Zero : ((global::Java.Lang.Object) key).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Cossacklabs.Themis.SecureCell.IContextImprint> (__rm.Handle, JniHandleOwnership.TransferLocalRef)!;
			} finally {
				global::System.GC.KeepAlive (key);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.cossacklabs.themis']/class[@name='SecureCell']/method[@name='SealWithKey' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("SealWithKey", "([B)Lcom/cossacklabs/themis/SecureCell$Seal;", "")]
		public static unsafe global::Com.Cossacklabs.Themis.SecureCell.ISeal SealWithKey (byte[]? key)
		{
			const string __id = "SealWithKey.([B)Lcom/cossacklabs/themis/SecureCell$Seal;";
			IntPtr native_key = JNIEnv.NewArray (key);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_key);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Cossacklabs.Themis.SecureCell.ISeal> (__rm.Handle, JniHandleOwnership.TransferLocalRef)!;
			} finally {
				if (key != null) {
					JNIEnv.CopyArray (native_key, key);
					JNIEnv.DeleteLocalRef (native_key);
				}
				global::System.GC.KeepAlive (key);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.cossacklabs.themis']/class[@name='SecureCell']/method[@name='SealWithKey' and count(parameter)=1 and parameter[1][@type='com.cossacklabs.themis.SymmetricKey']]"
		[Register ("SealWithKey", "(Lcom/cossacklabs/themis/SymmetricKey;)Lcom/cossacklabs/themis/SecureCell$Seal;", "")]
		public static unsafe global::Com.Cossacklabs.Themis.SecureCell.ISeal SealWithKey (global::Com.Cossacklabs.Themis.SymmetricKey? key)
		{
			const string __id = "SealWithKey.(Lcom/cossacklabs/themis/SymmetricKey;)Lcom/cossacklabs/themis/SecureCell$Seal;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((key == null) ? IntPtr.Zero : ((global::Java.Lang.Object) key).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Cossacklabs.Themis.SecureCell.ISeal> (__rm.Handle, JniHandleOwnership.TransferLocalRef)!;
			} finally {
				global::System.GC.KeepAlive (key);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.cossacklabs.themis']/class[@name='SecureCell']/method[@name='SealWithPassphrase' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("SealWithPassphrase", "([B)Lcom/cossacklabs/themis/SecureCell$Seal;", "")]
		public static unsafe global::Com.Cossacklabs.Themis.SecureCell.ISeal SealWithPassphrase (byte[]? encodedPassphrase)
		{
			const string __id = "SealWithPassphrase.([B)Lcom/cossacklabs/themis/SecureCell$Seal;";
			IntPtr native_encodedPassphrase = JNIEnv.NewArray (encodedPassphrase);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_encodedPassphrase);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Cossacklabs.Themis.SecureCell.ISeal> (__rm.Handle, JniHandleOwnership.TransferLocalRef)!;
			} finally {
				if (encodedPassphrase != null) {
					JNIEnv.CopyArray (native_encodedPassphrase, encodedPassphrase);
					JNIEnv.DeleteLocalRef (native_encodedPassphrase);
				}
				global::System.GC.KeepAlive (encodedPassphrase);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.cossacklabs.themis']/class[@name='SecureCell']/method[@name='SealWithPassphrase' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("SealWithPassphrase", "(Ljava/lang/String;)Lcom/cossacklabs/themis/SecureCell$Seal;", "")]
		public static unsafe global::Com.Cossacklabs.Themis.SecureCell.ISeal SealWithPassphrase (string? passphrase)
		{
			const string __id = "SealWithPassphrase.(Ljava/lang/String;)Lcom/cossacklabs/themis/SecureCell$Seal;";
			IntPtr native_passphrase = JNIEnv.NewString ((string?)passphrase);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_passphrase);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Cossacklabs.Themis.SecureCell.ISeal> (__rm.Handle, JniHandleOwnership.TransferLocalRef)!;
			} finally {
				JNIEnv.DeleteLocalRef (native_passphrase);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.cossacklabs.themis']/class[@name='SecureCell']/method[@name='SealWithPassphrase' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.nio.charset.Charset']]"
		[Register ("SealWithPassphrase", "(Ljava/lang/String;Ljava/nio/charset/Charset;)Lcom/cossacklabs/themis/SecureCell$Seal;", "")]
		public static unsafe global::Com.Cossacklabs.Themis.SecureCell.ISeal SealWithPassphrase (string? passphrase, global::Java.Nio.Charset.Charset? charset)
		{
			const string __id = "SealWithPassphrase.(Ljava/lang/String;Ljava/nio/charset/Charset;)Lcom/cossacklabs/themis/SecureCell$Seal;";
			IntPtr native_passphrase = JNIEnv.NewString ((string?)passphrase);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_passphrase);
				__args [1] = new JniArgumentValue ((charset == null) ? IntPtr.Zero : ((global::Java.Lang.Object) charset).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Cossacklabs.Themis.SecureCell.ISeal> (__rm.Handle, JniHandleOwnership.TransferLocalRef)!;
			} finally {
				JNIEnv.DeleteLocalRef (native_passphrase);
				global::System.GC.KeepAlive (charset);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.cossacklabs.themis']/class[@name='SecureCell']/method[@name='TokenProtectWithKey' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("TokenProtectWithKey", "([B)Lcom/cossacklabs/themis/SecureCell$TokenProtect;", "")]
		public static unsafe global::Com.Cossacklabs.Themis.SecureCell.ITokenProtect TokenProtectWithKey (byte[]? key)
		{
			const string __id = "TokenProtectWithKey.([B)Lcom/cossacklabs/themis/SecureCell$TokenProtect;";
			IntPtr native_key = JNIEnv.NewArray (key);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_key);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Cossacklabs.Themis.SecureCell.ITokenProtect> (__rm.Handle, JniHandleOwnership.TransferLocalRef)!;
			} finally {
				if (key != null) {
					JNIEnv.CopyArray (native_key, key);
					JNIEnv.DeleteLocalRef (native_key);
				}
				global::System.GC.KeepAlive (key);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.cossacklabs.themis']/class[@name='SecureCell']/method[@name='TokenProtectWithKey' and count(parameter)=1 and parameter[1][@type='com.cossacklabs.themis.SymmetricKey']]"
		[Register ("TokenProtectWithKey", "(Lcom/cossacklabs/themis/SymmetricKey;)Lcom/cossacklabs/themis/SecureCell$TokenProtect;", "")]
		public static unsafe global::Com.Cossacklabs.Themis.SecureCell.ITokenProtect TokenProtectWithKey (global::Com.Cossacklabs.Themis.SymmetricKey? key)
		{
			const string __id = "TokenProtectWithKey.(Lcom/cossacklabs/themis/SymmetricKey;)Lcom/cossacklabs/themis/SecureCell$TokenProtect;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((key == null) ? IntPtr.Zero : ((global::Java.Lang.Object) key).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Cossacklabs.Themis.SecureCell.ITokenProtect> (__rm.Handle, JniHandleOwnership.TransferLocalRef)!;
			} finally {
				global::System.GC.KeepAlive (key);
			}
		}

		static Delegate? cb_protect_arrayBarrayB;
#pragma warning disable 0169
		[global::System.Obsolete]
		static Delegate GetProtect_arrayBarrayBHandler ()
		{
			if (cb_protect_arrayBarrayB == null)
				cb_protect_arrayBarrayB = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_L) n_Protect_arrayBarrayB);
			return cb_protect_arrayBarrayB;
		}

		[global::System.Obsolete]
		static IntPtr n_Protect_arrayBarrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_context, IntPtr native_data)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Cossacklabs.Themis.SecureCell> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var context = (byte[]?) JNIEnv.GetArray (native_context, JniHandleOwnership.DoNotTransfer, typeof (byte));
			var data = (byte[]?) JNIEnv.GetArray (native_data, JniHandleOwnership.DoNotTransfer, typeof (byte));
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Protect (context, data));
			if (context != null)
				JNIEnv.CopyArray (context, native_context);
			if (data != null)
				JNIEnv.CopyArray (data, native_data);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.cossacklabs.themis']/class[@name='SecureCell']/method[@name='protect' and count(parameter)=2 and parameter[1][@type='byte[]'] and parameter[2][@type='byte[]']]"
		[global::System.Obsolete (@"deprecated")]
		[Register ("protect", "([B[B)Lcom/cossacklabs/themis/SecureCellData;", "GetProtect_arrayBarrayBHandler")]
		public virtual unsafe global::Com.Cossacklabs.Themis.SecureCellData? Protect (byte[]? context, byte[]? data)
		{
			const string __id = "protect.([B[B)Lcom/cossacklabs/themis/SecureCellData;";
			IntPtr native_context = JNIEnv.NewArray (context);
			IntPtr native_data = JNIEnv.NewArray (data);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_context);
				__args [1] = new JniArgumentValue (native_data);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Cossacklabs.Themis.SecureCellData> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				if (context != null) {
					JNIEnv.CopyArray (native_context, context);
					JNIEnv.DeleteLocalRef (native_context);
				}
				if (data != null) {
					JNIEnv.CopyArray (native_data, data);
					JNIEnv.DeleteLocalRef (native_data);
				}
				global::System.GC.KeepAlive (context);
				global::System.GC.KeepAlive (data);
			}
		}

		static Delegate? cb_protect_arrayBarrayBarrayB;
#pragma warning disable 0169
		[global::System.Obsolete]
		static Delegate GetProtect_arrayBarrayBarrayBHandler ()
		{
			if (cb_protect_arrayBarrayBarrayB == null)
				cb_protect_arrayBarrayBarrayB = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLL_L) n_Protect_arrayBarrayBarrayB);
			return cb_protect_arrayBarrayBarrayB;
		}

		[global::System.Obsolete]
		static IntPtr n_Protect_arrayBarrayBarrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_key, IntPtr native_context, IntPtr native_data)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Cossacklabs.Themis.SecureCell> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var key = (byte[]?) JNIEnv.GetArray (native_key, JniHandleOwnership.DoNotTransfer, typeof (byte));
			var context = (byte[]?) JNIEnv.GetArray (native_context, JniHandleOwnership.DoNotTransfer, typeof (byte));
			var data = (byte[]?) JNIEnv.GetArray (native_data, JniHandleOwnership.DoNotTransfer, typeof (byte));
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Protect (key, context, data));
			if (key != null)
				JNIEnv.CopyArray (key, native_key);
			if (context != null)
				JNIEnv.CopyArray (context, native_context);
			if (data != null)
				JNIEnv.CopyArray (data, native_data);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.cossacklabs.themis']/class[@name='SecureCell']/method[@name='protect' and count(parameter)=3 and parameter[1][@type='byte[]'] and parameter[2][@type='byte[]'] and parameter[3][@type='byte[]']]"
		[global::System.Obsolete (@"deprecated")]
		[Register ("protect", "([B[B[B)Lcom/cossacklabs/themis/SecureCellData;", "GetProtect_arrayBarrayBarrayBHandler")]
		public virtual unsafe global::Com.Cossacklabs.Themis.SecureCellData? Protect (byte[]? key, byte[]? context, byte[]? data)
		{
			const string __id = "protect.([B[B[B)Lcom/cossacklabs/themis/SecureCellData;";
			IntPtr native_key = JNIEnv.NewArray (key);
			IntPtr native_context = JNIEnv.NewArray (context);
			IntPtr native_data = JNIEnv.NewArray (data);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_key);
				__args [1] = new JniArgumentValue (native_context);
				__args [2] = new JniArgumentValue (native_data);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Cossacklabs.Themis.SecureCellData> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				if (key != null) {
					JNIEnv.CopyArray (native_key, key);
					JNIEnv.DeleteLocalRef (native_key);
				}
				if (context != null) {
					JNIEnv.CopyArray (native_context, context);
					JNIEnv.DeleteLocalRef (native_context);
				}
				if (data != null) {
					JNIEnv.CopyArray (native_data, data);
					JNIEnv.DeleteLocalRef (native_data);
				}
				global::System.GC.KeepAlive (key);
				global::System.GC.KeepAlive (context);
				global::System.GC.KeepAlive (data);
			}
		}

		static Delegate? cb_protect_Ljava_lang_String_arrayB;
#pragma warning disable 0169
		[global::System.Obsolete]
		static Delegate GetProtect_Ljava_lang_String_arrayBHandler ()
		{
			if (cb_protect_Ljava_lang_String_arrayB == null)
				cb_protect_Ljava_lang_String_arrayB = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_L) n_Protect_Ljava_lang_String_arrayB);
			return cb_protect_Ljava_lang_String_arrayB;
		}

		[global::System.Obsolete]
		static IntPtr n_Protect_Ljava_lang_String_arrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_context, IntPtr native_data)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Cossacklabs.Themis.SecureCell> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var context = JNIEnv.GetString (native_context, JniHandleOwnership.DoNotTransfer);
			var data = (byte[]?) JNIEnv.GetArray (native_data, JniHandleOwnership.DoNotTransfer, typeof (byte));
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Protect (context, data));
			if (data != null)
				JNIEnv.CopyArray (data, native_data);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.cossacklabs.themis']/class[@name='SecureCell']/method[@name='protect' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='byte[]']]"
		[global::System.Obsolete (@"deprecated")]
		[Register ("protect", "(Ljava/lang/String;[B)Lcom/cossacklabs/themis/SecureCellData;", "GetProtect_Ljava_lang_String_arrayBHandler")]
		public virtual unsafe global::Com.Cossacklabs.Themis.SecureCellData? Protect (string? context, byte[]? data)
		{
			const string __id = "protect.(Ljava/lang/String;[B)Lcom/cossacklabs/themis/SecureCellData;";
			IntPtr native_context = JNIEnv.NewString ((string?)context);
			IntPtr native_data = JNIEnv.NewArray (data);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_context);
				__args [1] = new JniArgumentValue (native_data);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Cossacklabs.Themis.SecureCellData> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_context);
				if (data != null) {
					JNIEnv.CopyArray (native_data, data);
					JNIEnv.DeleteLocalRef (native_data);
				}
				global::System.GC.KeepAlive (data);
			}
		}

		static Delegate? cb_protect_Ljava_lang_String_Ljava_lang_String_arrayB;
#pragma warning disable 0169
		[global::System.Obsolete]
		static Delegate GetProtect_Ljava_lang_String_Ljava_lang_String_arrayBHandler ()
		{
			if (cb_protect_Ljava_lang_String_Ljava_lang_String_arrayB == null)
				cb_protect_Ljava_lang_String_Ljava_lang_String_arrayB = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLL_L) n_Protect_Ljava_lang_String_Ljava_lang_String_arrayB);
			return cb_protect_Ljava_lang_String_Ljava_lang_String_arrayB;
		}

		[global::System.Obsolete]
		static IntPtr n_Protect_Ljava_lang_String_Ljava_lang_String_arrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_password, IntPtr native_context, IntPtr native_data)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Cossacklabs.Themis.SecureCell> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var password = JNIEnv.GetString (native_password, JniHandleOwnership.DoNotTransfer);
			var context = JNIEnv.GetString (native_context, JniHandleOwnership.DoNotTransfer);
			var data = (byte[]?) JNIEnv.GetArray (native_data, JniHandleOwnership.DoNotTransfer, typeof (byte));
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Protect (password, context, data));
			if (data != null)
				JNIEnv.CopyArray (data, native_data);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.cossacklabs.themis']/class[@name='SecureCell']/method[@name='protect' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='byte[]']]"
		[global::System.Obsolete (@"deprecated")]
		[Register ("protect", "(Ljava/lang/String;Ljava/lang/String;[B)Lcom/cossacklabs/themis/SecureCellData;", "GetProtect_Ljava_lang_String_Ljava_lang_String_arrayBHandler")]
		public virtual unsafe global::Com.Cossacklabs.Themis.SecureCellData? Protect (string? password, string? context, byte[]? data)
		{
			const string __id = "protect.(Ljava/lang/String;Ljava/lang/String;[B)Lcom/cossacklabs/themis/SecureCellData;";
			IntPtr native_password = JNIEnv.NewString ((string?)password);
			IntPtr native_context = JNIEnv.NewString ((string?)context);
			IntPtr native_data = JNIEnv.NewArray (data);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_password);
				__args [1] = new JniArgumentValue (native_context);
				__args [2] = new JniArgumentValue (native_data);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Cossacklabs.Themis.SecureCellData> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_password);
				JNIEnv.DeleteLocalRef (native_context);
				if (data != null) {
					JNIEnv.CopyArray (native_data, data);
					JNIEnv.DeleteLocalRef (native_data);
				}
				global::System.GC.KeepAlive (data);
			}
		}

		static Delegate? cb_unprotect_arrayBarrayBLcom_cossacklabs_themis_SecureCellData_;
#pragma warning disable 0169
		[global::System.Obsolete]
		static Delegate GetUnprotect_arrayBarrayBLcom_cossacklabs_themis_SecureCellData_Handler ()
		{
			if (cb_unprotect_arrayBarrayBLcom_cossacklabs_themis_SecureCellData_ == null)
				cb_unprotect_arrayBarrayBLcom_cossacklabs_themis_SecureCellData_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLL_L) n_Unprotect_arrayBarrayBLcom_cossacklabs_themis_SecureCellData_);
			return cb_unprotect_arrayBarrayBLcom_cossacklabs_themis_SecureCellData_;
		}

		[global::System.Obsolete]
		static IntPtr n_Unprotect_arrayBarrayBLcom_cossacklabs_themis_SecureCellData_ (IntPtr jnienv, IntPtr native__this, IntPtr native_key, IntPtr native_context, IntPtr native_protectedData)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Cossacklabs.Themis.SecureCell> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var key = (byte[]?) JNIEnv.GetArray (native_key, JniHandleOwnership.DoNotTransfer, typeof (byte));
			var context = (byte[]?) JNIEnv.GetArray (native_context, JniHandleOwnership.DoNotTransfer, typeof (byte));
			var protectedData = global::Java.Lang.Object.GetObject<global::Com.Cossacklabs.Themis.SecureCellData> (native_protectedData, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewArray (__this.Unprotect (key, context, protectedData));
			if (key != null)
				JNIEnv.CopyArray (key, native_key);
			if (context != null)
				JNIEnv.CopyArray (context, native_context);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.cossacklabs.themis']/class[@name='SecureCell']/method[@name='unprotect' and count(parameter)=3 and parameter[1][@type='byte[]'] and parameter[2][@type='byte[]'] and parameter[3][@type='com.cossacklabs.themis.SecureCellData']]"
		[global::System.Obsolete (@"deprecated")]
		[Register ("unprotect", "([B[BLcom/cossacklabs/themis/SecureCellData;)[B", "GetUnprotect_arrayBarrayBLcom_cossacklabs_themis_SecureCellData_Handler")]
		public virtual unsafe byte[]? Unprotect (byte[]? key, byte[]? context, global::Com.Cossacklabs.Themis.SecureCellData? protectedData)
		{
			const string __id = "unprotect.([B[BLcom/cossacklabs/themis/SecureCellData;)[B";
			IntPtr native_key = JNIEnv.NewArray (key);
			IntPtr native_context = JNIEnv.NewArray (context);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_key);
				__args [1] = new JniArgumentValue (native_context);
				__args [2] = new JniArgumentValue ((protectedData == null) ? IntPtr.Zero : ((global::Java.Lang.Object) protectedData).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return (byte[]?) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (byte));
			} finally {
				if (key != null) {
					JNIEnv.CopyArray (native_key, key);
					JNIEnv.DeleteLocalRef (native_key);
				}
				if (context != null) {
					JNIEnv.CopyArray (native_context, context);
					JNIEnv.DeleteLocalRef (native_context);
				}
				global::System.GC.KeepAlive (key);
				global::System.GC.KeepAlive (context);
				global::System.GC.KeepAlive (protectedData);
			}
		}

		static Delegate? cb_unprotect_arrayBLcom_cossacklabs_themis_SecureCellData_;
#pragma warning disable 0169
		[global::System.Obsolete]
		static Delegate GetUnprotect_arrayBLcom_cossacklabs_themis_SecureCellData_Handler ()
		{
			if (cb_unprotect_arrayBLcom_cossacklabs_themis_SecureCellData_ == null)
				cb_unprotect_arrayBLcom_cossacklabs_themis_SecureCellData_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_L) n_Unprotect_arrayBLcom_cossacklabs_themis_SecureCellData_);
			return cb_unprotect_arrayBLcom_cossacklabs_themis_SecureCellData_;
		}

		[global::System.Obsolete]
		static IntPtr n_Unprotect_arrayBLcom_cossacklabs_themis_SecureCellData_ (IntPtr jnienv, IntPtr native__this, IntPtr native_context, IntPtr native_protectedData)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Cossacklabs.Themis.SecureCell> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var context = (byte[]?) JNIEnv.GetArray (native_context, JniHandleOwnership.DoNotTransfer, typeof (byte));
			var protectedData = global::Java.Lang.Object.GetObject<global::Com.Cossacklabs.Themis.SecureCellData> (native_protectedData, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewArray (__this.Unprotect (context, protectedData));
			if (context != null)
				JNIEnv.CopyArray (context, native_context);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.cossacklabs.themis']/class[@name='SecureCell']/method[@name='unprotect' and count(parameter)=2 and parameter[1][@type='byte[]'] and parameter[2][@type='com.cossacklabs.themis.SecureCellData']]"
		[global::System.Obsolete (@"deprecated")]
		[Register ("unprotect", "([BLcom/cossacklabs/themis/SecureCellData;)[B", "GetUnprotect_arrayBLcom_cossacklabs_themis_SecureCellData_Handler")]
		public virtual unsafe byte[]? Unprotect (byte[]? context, global::Com.Cossacklabs.Themis.SecureCellData? protectedData)
		{
			const string __id = "unprotect.([BLcom/cossacklabs/themis/SecureCellData;)[B";
			IntPtr native_context = JNIEnv.NewArray (context);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_context);
				__args [1] = new JniArgumentValue ((protectedData == null) ? IntPtr.Zero : ((global::Java.Lang.Object) protectedData).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return (byte[]?) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (byte));
			} finally {
				if (context != null) {
					JNIEnv.CopyArray (native_context, context);
					JNIEnv.DeleteLocalRef (native_context);
				}
				global::System.GC.KeepAlive (context);
				global::System.GC.KeepAlive (protectedData);
			}
		}

		static Delegate? cb_unprotect_Ljava_lang_String_Lcom_cossacklabs_themis_SecureCellData_;
#pragma warning disable 0169
		[global::System.Obsolete]
		static Delegate GetUnprotect_Ljava_lang_String_Lcom_cossacklabs_themis_SecureCellData_Handler ()
		{
			if (cb_unprotect_Ljava_lang_String_Lcom_cossacklabs_themis_SecureCellData_ == null)
				cb_unprotect_Ljava_lang_String_Lcom_cossacklabs_themis_SecureCellData_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_L) n_Unprotect_Ljava_lang_String_Lcom_cossacklabs_themis_SecureCellData_);
			return cb_unprotect_Ljava_lang_String_Lcom_cossacklabs_themis_SecureCellData_;
		}

		[global::System.Obsolete]
		static IntPtr n_Unprotect_Ljava_lang_String_Lcom_cossacklabs_themis_SecureCellData_ (IntPtr jnienv, IntPtr native__this, IntPtr native_context, IntPtr native_protectedData)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Cossacklabs.Themis.SecureCell> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var context = JNIEnv.GetString (native_context, JniHandleOwnership.DoNotTransfer);
			var protectedData = global::Java.Lang.Object.GetObject<global::Com.Cossacklabs.Themis.SecureCellData> (native_protectedData, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewArray (__this.Unprotect (context, protectedData));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.cossacklabs.themis']/class[@name='SecureCell']/method[@name='unprotect' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='com.cossacklabs.themis.SecureCellData']]"
		[global::System.Obsolete (@"deprecated")]
		[Register ("unprotect", "(Ljava/lang/String;Lcom/cossacklabs/themis/SecureCellData;)[B", "GetUnprotect_Ljava_lang_String_Lcom_cossacklabs_themis_SecureCellData_Handler")]
		public virtual unsafe byte[]? Unprotect (string? context, global::Com.Cossacklabs.Themis.SecureCellData? protectedData)
		{
			const string __id = "unprotect.(Ljava/lang/String;Lcom/cossacklabs/themis/SecureCellData;)[B";
			IntPtr native_context = JNIEnv.NewString ((string?)context);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_context);
				__args [1] = new JniArgumentValue ((protectedData == null) ? IntPtr.Zero : ((global::Java.Lang.Object) protectedData).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return (byte[]?) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (byte));
			} finally {
				JNIEnv.DeleteLocalRef (native_context);
				global::System.GC.KeepAlive (protectedData);
			}
		}

		static Delegate? cb_unprotect_Ljava_lang_String_Ljava_lang_String_Lcom_cossacklabs_themis_SecureCellData_;
#pragma warning disable 0169
		[global::System.Obsolete]
		static Delegate GetUnprotect_Ljava_lang_String_Ljava_lang_String_Lcom_cossacklabs_themis_SecureCellData_Handler ()
		{
			if (cb_unprotect_Ljava_lang_String_Ljava_lang_String_Lcom_cossacklabs_themis_SecureCellData_ == null)
				cb_unprotect_Ljava_lang_String_Ljava_lang_String_Lcom_cossacklabs_themis_SecureCellData_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLL_L) n_Unprotect_Ljava_lang_String_Ljava_lang_String_Lcom_cossacklabs_themis_SecureCellData_);
			return cb_unprotect_Ljava_lang_String_Ljava_lang_String_Lcom_cossacklabs_themis_SecureCellData_;
		}

		[global::System.Obsolete]
		static IntPtr n_Unprotect_Ljava_lang_String_Ljava_lang_String_Lcom_cossacklabs_themis_SecureCellData_ (IntPtr jnienv, IntPtr native__this, IntPtr native_password, IntPtr native_context, IntPtr native_protectedData)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Cossacklabs.Themis.SecureCell> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var password = JNIEnv.GetString (native_password, JniHandleOwnership.DoNotTransfer);
			var context = JNIEnv.GetString (native_context, JniHandleOwnership.DoNotTransfer);
			var protectedData = global::Java.Lang.Object.GetObject<global::Com.Cossacklabs.Themis.SecureCellData> (native_protectedData, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewArray (__this.Unprotect (password, context, protectedData));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.cossacklabs.themis']/class[@name='SecureCell']/method[@name='unprotect' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='com.cossacklabs.themis.SecureCellData']]"
		[global::System.Obsolete (@"deprecated")]
		[Register ("unprotect", "(Ljava/lang/String;Ljava/lang/String;Lcom/cossacklabs/themis/SecureCellData;)[B", "GetUnprotect_Ljava_lang_String_Ljava_lang_String_Lcom_cossacklabs_themis_SecureCellData_Handler")]
		public virtual unsafe byte[]? Unprotect (string? password, string? context, global::Com.Cossacklabs.Themis.SecureCellData? protectedData)
		{
			const string __id = "unprotect.(Ljava/lang/String;Ljava/lang/String;Lcom/cossacklabs/themis/SecureCellData;)[B";
			IntPtr native_password = JNIEnv.NewString ((string?)password);
			IntPtr native_context = JNIEnv.NewString ((string?)context);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_password);
				__args [1] = new JniArgumentValue (native_context);
				__args [2] = new JniArgumentValue ((protectedData == null) ? IntPtr.Zero : ((global::Java.Lang.Object) protectedData).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return (byte[]?) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (byte));
			} finally {
				JNIEnv.DeleteLocalRef (native_password);
				JNIEnv.DeleteLocalRef (native_context);
				global::System.GC.KeepAlive (protectedData);
			}
		}

	}
}

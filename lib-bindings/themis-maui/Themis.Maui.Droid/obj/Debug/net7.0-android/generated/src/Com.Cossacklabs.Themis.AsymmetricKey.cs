using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Cossacklabs.Themis {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.cossacklabs.themis']/class[@name='AsymmetricKey']"
	[global::Android.Runtime.Register ("com/cossacklabs/themis/AsymmetricKey", DoNotGenerateAcw=true)]
	public abstract partial class AsymmetricKey : global::Java.Lang.Object {
		// Metadata.xml XPath field reference: path="/api/package[@name='com.cossacklabs.themis']/class[@name='AsymmetricKey']/field[@name='KEYTYPE_EC']"
		[Register ("KEYTYPE_EC")]
		public const int KeytypeEc = (int) 0;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.cossacklabs.themis']/class[@name='AsymmetricKey']/field[@name='KEYTYPE_RSA']"
		[Register ("KEYTYPE_RSA")]
		public const int KeytypeRsa = (int) 1;

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/cossacklabs/themis/AsymmetricKey", typeof (AsymmetricKey));

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

		protected AsymmetricKey (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.cossacklabs.themis']/class[@name='AsymmetricKey']/constructor[@name='AsymmetricKey' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register (".ctor", "([B)V", "")]
		public unsafe AsymmetricKey (byte[]? key) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

		static Delegate? cb_toByteArray;
#pragma warning disable 0169
		static Delegate GetToByteArrayHandler ()
		{
			if (cb_toByteArray == null)
				cb_toByteArray = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_ToByteArray);
			return cb_toByteArray;
		}

		static IntPtr n_ToByteArray (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Cossacklabs.Themis.AsymmetricKey> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return JNIEnv.NewArray (__this.ToByteArray ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.cossacklabs.themis']/class[@name='AsymmetricKey']/method[@name='toByteArray' and count(parameter)=0]"
		[Register ("toByteArray", "()[B", "GetToByteArrayHandler")]
		public virtual unsafe byte[]? ToByteArray ()
		{
			const string __id = "toByteArray.()[B";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return (byte[]?) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (byte));
			} finally {
			}
		}

	}

	[global::Android.Runtime.Register ("com/cossacklabs/themis/AsymmetricKey", DoNotGenerateAcw=true)]
	internal partial class AsymmetricKeyInvoker : AsymmetricKey {
		public AsymmetricKeyInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer)
		{
		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/cossacklabs/themis/AsymmetricKey", typeof (AsymmetricKeyInvoker));

		[global::System.Diagnostics.DebuggerBrowsable (global::System.Diagnostics.DebuggerBrowsableState.Never)]
		[global::System.ComponentModel.EditorBrowsable (global::System.ComponentModel.EditorBrowsableState.Never)]
		public override global::Java.Interop.JniPeerMembers JniPeerMembers {
			get { return _members; }
		}

		[global::System.Diagnostics.DebuggerBrowsable (global::System.Diagnostics.DebuggerBrowsableState.Never)]
		[global::System.ComponentModel.EditorBrowsable (global::System.ComponentModel.EditorBrowsableState.Never)]
		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

	}
}

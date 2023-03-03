using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Cossacklabs.Themis {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.cossacklabs.themis']/class[@name='SecureMessage']"
	[global::Android.Runtime.Register ("com/cossacklabs/themis/SecureMessage", DoNotGenerateAcw=true)]
	public partial class SecureMessage : global::Java.Lang.Object {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/cossacklabs/themis/SecureMessage", typeof (SecureMessage));

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

		protected SecureMessage (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.cossacklabs.themis']/class[@name='SecureMessage']/constructor[@name='SecureMessage' and count(parameter)=1 and parameter[1][@type='com.cossacklabs.themis.PrivateKey']]"
		[Register (".ctor", "(Lcom/cossacklabs/themis/PrivateKey;)V", "")]
		public unsafe SecureMessage (global::Com.Cossacklabs.Themis.PrivateKey? privateKey) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lcom/cossacklabs/themis/PrivateKey;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((privateKey == null) ? IntPtr.Zero : ((global::Java.Lang.Object) privateKey).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (privateKey);
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.cossacklabs.themis']/class[@name='SecureMessage']/constructor[@name='SecureMessage' and count(parameter)=2 and parameter[1][@type='com.cossacklabs.themis.PrivateKey'] and parameter[2][@type='com.cossacklabs.themis.PublicKey']]"
		[Register (".ctor", "(Lcom/cossacklabs/themis/PrivateKey;Lcom/cossacklabs/themis/PublicKey;)V", "")]
		public unsafe SecureMessage (global::Com.Cossacklabs.Themis.PrivateKey? privateKey, global::Com.Cossacklabs.Themis.PublicKey? peerPublicKey) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lcom/cossacklabs/themis/PrivateKey;Lcom/cossacklabs/themis/PublicKey;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((privateKey == null) ? IntPtr.Zero : ((global::Java.Lang.Object) privateKey).Handle);
				__args [1] = new JniArgumentValue ((peerPublicKey == null) ? IntPtr.Zero : ((global::Java.Lang.Object) peerPublicKey).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (privateKey);
				global::System.GC.KeepAlive (peerPublicKey);
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.cossacklabs.themis']/class[@name='SecureMessage']/constructor[@name='SecureMessage' and count(parameter)=1 and parameter[1][@type='com.cossacklabs.themis.PublicKey']]"
		[Register (".ctor", "(Lcom/cossacklabs/themis/PublicKey;)V", "")]
		public unsafe SecureMessage (global::Com.Cossacklabs.Themis.PublicKey? peerPublicKey) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lcom/cossacklabs/themis/PublicKey;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((peerPublicKey == null) ? IntPtr.Zero : ((global::Java.Lang.Object) peerPublicKey).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (peerPublicKey);
			}
		}

		static Delegate? cb_sign_arrayB;
#pragma warning disable 0169
		static Delegate GetSign_arrayBHandler ()
		{
			if (cb_sign_arrayB == null)
				cb_sign_arrayB = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_Sign_arrayB);
			return cb_sign_arrayB;
		}

		static IntPtr n_Sign_arrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_message)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Cossacklabs.Themis.SecureMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var message = (byte[]?) JNIEnv.GetArray (native_message, JniHandleOwnership.DoNotTransfer, typeof (byte));
			IntPtr __ret = JNIEnv.NewArray (__this.Sign (message));
			if (message != null)
				JNIEnv.CopyArray (message, native_message);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.cossacklabs.themis']/class[@name='SecureMessage']/method[@name='sign' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("sign", "([B)[B", "GetSign_arrayBHandler")]
		public virtual unsafe byte[]? Sign (byte[]? message)
		{
			const string __id = "sign.([B)[B";
			IntPtr native_message = JNIEnv.NewArray (message);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_message);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return (byte[]?) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (byte));
			} finally {
				if (message != null) {
					JNIEnv.CopyArray (native_message, message);
					JNIEnv.DeleteLocalRef (native_message);
				}
				global::System.GC.KeepAlive (message);
			}
		}

		static Delegate? cb_unwrap_arrayB;
#pragma warning disable 0169
		static Delegate GetUnwrap_arrayBHandler ()
		{
			if (cb_unwrap_arrayB == null)
				cb_unwrap_arrayB = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_Unwrap_arrayB);
			return cb_unwrap_arrayB;
		}

		static IntPtr n_Unwrap_arrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_message)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Cossacklabs.Themis.SecureMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var message = (byte[]?) JNIEnv.GetArray (native_message, JniHandleOwnership.DoNotTransfer, typeof (byte));
			IntPtr __ret = JNIEnv.NewArray (__this.Unwrap (message));
			if (message != null)
				JNIEnv.CopyArray (message, native_message);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.cossacklabs.themis']/class[@name='SecureMessage']/method[@name='unwrap' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("unwrap", "([B)[B", "GetUnwrap_arrayBHandler")]
		public virtual unsafe byte[]? Unwrap (byte[]? message)
		{
			const string __id = "unwrap.([B)[B";
			IntPtr native_message = JNIEnv.NewArray (message);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_message);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return (byte[]?) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (byte));
			} finally {
				if (message != null) {
					JNIEnv.CopyArray (native_message, message);
					JNIEnv.DeleteLocalRef (native_message);
				}
				global::System.GC.KeepAlive (message);
			}
		}

		static Delegate? cb_unwrap_arrayBLcom_cossacklabs_themis_PublicKey_;
#pragma warning disable 0169
		static Delegate GetUnwrap_arrayBLcom_cossacklabs_themis_PublicKey_Handler ()
		{
			if (cb_unwrap_arrayBLcom_cossacklabs_themis_PublicKey_ == null)
				cb_unwrap_arrayBLcom_cossacklabs_themis_PublicKey_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_L) n_Unwrap_arrayBLcom_cossacklabs_themis_PublicKey_);
			return cb_unwrap_arrayBLcom_cossacklabs_themis_PublicKey_;
		}

		static IntPtr n_Unwrap_arrayBLcom_cossacklabs_themis_PublicKey_ (IntPtr jnienv, IntPtr native__this, IntPtr native_message, IntPtr native_peerPublicKey)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Cossacklabs.Themis.SecureMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var message = (byte[]?) JNIEnv.GetArray (native_message, JniHandleOwnership.DoNotTransfer, typeof (byte));
			var peerPublicKey = global::Java.Lang.Object.GetObject<global::Com.Cossacklabs.Themis.PublicKey> (native_peerPublicKey, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewArray (__this.Unwrap (message, peerPublicKey));
			if (message != null)
				JNIEnv.CopyArray (message, native_message);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.cossacklabs.themis']/class[@name='SecureMessage']/method[@name='unwrap' and count(parameter)=2 and parameter[1][@type='byte[]'] and parameter[2][@type='com.cossacklabs.themis.PublicKey']]"
		[Register ("unwrap", "([BLcom/cossacklabs/themis/PublicKey;)[B", "GetUnwrap_arrayBLcom_cossacklabs_themis_PublicKey_Handler")]
		public virtual unsafe byte[]? Unwrap (byte[]? message, global::Com.Cossacklabs.Themis.PublicKey? peerPublicKey)
		{
			const string __id = "unwrap.([BLcom/cossacklabs/themis/PublicKey;)[B";
			IntPtr native_message = JNIEnv.NewArray (message);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_message);
				__args [1] = new JniArgumentValue ((peerPublicKey == null) ? IntPtr.Zero : ((global::Java.Lang.Object) peerPublicKey).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return (byte[]?) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (byte));
			} finally {
				if (message != null) {
					JNIEnv.CopyArray (native_message, message);
					JNIEnv.DeleteLocalRef (native_message);
				}
				global::System.GC.KeepAlive (message);
				global::System.GC.KeepAlive (peerPublicKey);
			}
		}

		static Delegate? cb_verify_arrayB;
#pragma warning disable 0169
		static Delegate GetVerify_arrayBHandler ()
		{
			if (cb_verify_arrayB == null)
				cb_verify_arrayB = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_Verify_arrayB);
			return cb_verify_arrayB;
		}

		static IntPtr n_Verify_arrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_message)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Cossacklabs.Themis.SecureMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var message = (byte[]?) JNIEnv.GetArray (native_message, JniHandleOwnership.DoNotTransfer, typeof (byte));
			IntPtr __ret = JNIEnv.NewArray (__this.Verify (message));
			if (message != null)
				JNIEnv.CopyArray (message, native_message);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.cossacklabs.themis']/class[@name='SecureMessage']/method[@name='verify' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("verify", "([B)[B", "GetVerify_arrayBHandler")]
		public virtual unsafe byte[]? Verify (byte[]? message)
		{
			const string __id = "verify.([B)[B";
			IntPtr native_message = JNIEnv.NewArray (message);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_message);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return (byte[]?) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (byte));
			} finally {
				if (message != null) {
					JNIEnv.CopyArray (native_message, message);
					JNIEnv.DeleteLocalRef (native_message);
				}
				global::System.GC.KeepAlive (message);
			}
		}

		static Delegate? cb_verify_arrayBLcom_cossacklabs_themis_PublicKey_;
#pragma warning disable 0169
		static Delegate GetVerify_arrayBLcom_cossacklabs_themis_PublicKey_Handler ()
		{
			if (cb_verify_arrayBLcom_cossacklabs_themis_PublicKey_ == null)
				cb_verify_arrayBLcom_cossacklabs_themis_PublicKey_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_L) n_Verify_arrayBLcom_cossacklabs_themis_PublicKey_);
			return cb_verify_arrayBLcom_cossacklabs_themis_PublicKey_;
		}

		static IntPtr n_Verify_arrayBLcom_cossacklabs_themis_PublicKey_ (IntPtr jnienv, IntPtr native__this, IntPtr native_message, IntPtr native_peerPublicKey)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Cossacklabs.Themis.SecureMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var message = (byte[]?) JNIEnv.GetArray (native_message, JniHandleOwnership.DoNotTransfer, typeof (byte));
			var peerPublicKey = global::Java.Lang.Object.GetObject<global::Com.Cossacklabs.Themis.PublicKey> (native_peerPublicKey, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewArray (__this.Verify (message, peerPublicKey));
			if (message != null)
				JNIEnv.CopyArray (message, native_message);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.cossacklabs.themis']/class[@name='SecureMessage']/method[@name='verify' and count(parameter)=2 and parameter[1][@type='byte[]'] and parameter[2][@type='com.cossacklabs.themis.PublicKey']]"
		[Register ("verify", "([BLcom/cossacklabs/themis/PublicKey;)[B", "GetVerify_arrayBLcom_cossacklabs_themis_PublicKey_Handler")]
		public virtual unsafe byte[]? Verify (byte[]? message, global::Com.Cossacklabs.Themis.PublicKey? peerPublicKey)
		{
			const string __id = "verify.([BLcom/cossacklabs/themis/PublicKey;)[B";
			IntPtr native_message = JNIEnv.NewArray (message);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_message);
				__args [1] = new JniArgumentValue ((peerPublicKey == null) ? IntPtr.Zero : ((global::Java.Lang.Object) peerPublicKey).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return (byte[]?) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (byte));
			} finally {
				if (message != null) {
					JNIEnv.CopyArray (native_message, message);
					JNIEnv.DeleteLocalRef (native_message);
				}
				global::System.GC.KeepAlive (message);
				global::System.GC.KeepAlive (peerPublicKey);
			}
		}

		static Delegate? cb_wrap_arrayB;
#pragma warning disable 0169
		static Delegate GetWrap_arrayBHandler ()
		{
			if (cb_wrap_arrayB == null)
				cb_wrap_arrayB = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_Wrap_arrayB);
			return cb_wrap_arrayB;
		}

		static IntPtr n_Wrap_arrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_message)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Cossacklabs.Themis.SecureMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var message = (byte[]?) JNIEnv.GetArray (native_message, JniHandleOwnership.DoNotTransfer, typeof (byte));
			IntPtr __ret = JNIEnv.NewArray (__this.Wrap (message));
			if (message != null)
				JNIEnv.CopyArray (message, native_message);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.cossacklabs.themis']/class[@name='SecureMessage']/method[@name='wrap' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("wrap", "([B)[B", "GetWrap_arrayBHandler")]
		public virtual unsafe byte[]? Wrap (byte[]? message)
		{
			const string __id = "wrap.([B)[B";
			IntPtr native_message = JNIEnv.NewArray (message);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_message);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return (byte[]?) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (byte));
			} finally {
				if (message != null) {
					JNIEnv.CopyArray (native_message, message);
					JNIEnv.DeleteLocalRef (native_message);
				}
				global::System.GC.KeepAlive (message);
			}
		}

		static Delegate? cb_wrap_arrayBLcom_cossacklabs_themis_PublicKey_;
#pragma warning disable 0169
		static Delegate GetWrap_arrayBLcom_cossacklabs_themis_PublicKey_Handler ()
		{
			if (cb_wrap_arrayBLcom_cossacklabs_themis_PublicKey_ == null)
				cb_wrap_arrayBLcom_cossacklabs_themis_PublicKey_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_L) n_Wrap_arrayBLcom_cossacklabs_themis_PublicKey_);
			return cb_wrap_arrayBLcom_cossacklabs_themis_PublicKey_;
		}

		static IntPtr n_Wrap_arrayBLcom_cossacklabs_themis_PublicKey_ (IntPtr jnienv, IntPtr native__this, IntPtr native_message, IntPtr native_peerPublicKey)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Cossacklabs.Themis.SecureMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var message = (byte[]?) JNIEnv.GetArray (native_message, JniHandleOwnership.DoNotTransfer, typeof (byte));
			var peerPublicKey = global::Java.Lang.Object.GetObject<global::Com.Cossacklabs.Themis.PublicKey> (native_peerPublicKey, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewArray (__this.Wrap (message, peerPublicKey));
			if (message != null)
				JNIEnv.CopyArray (message, native_message);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.cossacklabs.themis']/class[@name='SecureMessage']/method[@name='wrap' and count(parameter)=2 and parameter[1][@type='byte[]'] and parameter[2][@type='com.cossacklabs.themis.PublicKey']]"
		[Register ("wrap", "([BLcom/cossacklabs/themis/PublicKey;)[B", "GetWrap_arrayBLcom_cossacklabs_themis_PublicKey_Handler")]
		public virtual unsafe byte[]? Wrap (byte[]? message, global::Com.Cossacklabs.Themis.PublicKey? peerPublicKey)
		{
			const string __id = "wrap.([BLcom/cossacklabs/themis/PublicKey;)[B";
			IntPtr native_message = JNIEnv.NewArray (message);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_message);
				__args [1] = new JniArgumentValue ((peerPublicKey == null) ? IntPtr.Zero : ((global::Java.Lang.Object) peerPublicKey).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return (byte[]?) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (byte));
			} finally {
				if (message != null) {
					JNIEnv.CopyArray (native_message, message);
					JNIEnv.DeleteLocalRef (native_message);
				}
				global::System.GC.KeepAlive (message);
				global::System.GC.KeepAlive (peerPublicKey);
			}
		}

	}
}

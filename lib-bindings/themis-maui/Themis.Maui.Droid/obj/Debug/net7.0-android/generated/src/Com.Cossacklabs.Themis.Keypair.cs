using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Cossacklabs.Themis {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.cossacklabs.themis']/class[@name='Keypair']"
	[global::Android.Runtime.Register ("com/cossacklabs/themis/Keypair", DoNotGenerateAcw=true)]
	public partial class Keypair : global::Java.Lang.Object {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/cossacklabs/themis/Keypair", typeof (Keypair));

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

		protected Keypair (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.cossacklabs.themis']/class[@name='Keypair']/constructor[@name='Keypair' and count(parameter)=2 and parameter[1][@type='com.cossacklabs.themis.PrivateKey'] and parameter[2][@type='com.cossacklabs.themis.PublicKey']]"
		[Register (".ctor", "(Lcom/cossacklabs/themis/PrivateKey;Lcom/cossacklabs/themis/PublicKey;)V", "")]
		public unsafe Keypair (global::Com.Cossacklabs.Themis.PrivateKey? privateKey, global::Com.Cossacklabs.Themis.PublicKey? publicKey) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lcom/cossacklabs/themis/PrivateKey;Lcom/cossacklabs/themis/PublicKey;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((privateKey == null) ? IntPtr.Zero : ((global::Java.Lang.Object) privateKey).Handle);
				__args [1] = new JniArgumentValue ((publicKey == null) ? IntPtr.Zero : ((global::Java.Lang.Object) publicKey).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (privateKey);
				global::System.GC.KeepAlive (publicKey);
			}
		}

		static Delegate? cb_getPrivateKey;
#pragma warning disable 0169
		static Delegate GetGetPrivateKeyHandler ()
		{
			if (cb_getPrivateKey == null)
				cb_getPrivateKey = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetPrivateKey);
			return cb_getPrivateKey;
		}

		static IntPtr n_GetPrivateKey (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Cossacklabs.Themis.Keypair> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return JNIEnv.ToLocalJniHandle (__this.PrivateKey);
		}
#pragma warning restore 0169

		public virtual unsafe global::Com.Cossacklabs.Themis.PrivateKey? PrivateKey {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.cossacklabs.themis']/class[@name='Keypair']/method[@name='getPrivateKey' and count(parameter)=0]"
			[Register ("getPrivateKey", "()Lcom/cossacklabs/themis/PrivateKey;", "GetGetPrivateKeyHandler")]
			get {
				const string __id = "getPrivateKey.()Lcom/cossacklabs/themis/PrivateKey;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Cossacklabs.Themis.PrivateKey> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate? cb_getPublicKey;
#pragma warning disable 0169
		static Delegate GetGetPublicKeyHandler ()
		{
			if (cb_getPublicKey == null)
				cb_getPublicKey = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetPublicKey);
			return cb_getPublicKey;
		}

		static IntPtr n_GetPublicKey (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Cossacklabs.Themis.Keypair> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return JNIEnv.ToLocalJniHandle (__this.PublicKey);
		}
#pragma warning restore 0169

		public virtual unsafe global::Com.Cossacklabs.Themis.PublicKey? PublicKey {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.cossacklabs.themis']/class[@name='Keypair']/method[@name='getPublicKey' and count(parameter)=0]"
			[Register ("getPublicKey", "()Lcom/cossacklabs/themis/PublicKey;", "GetGetPublicKeyHandler")]
			get {
				const string __id = "getPublicKey.()Lcom/cossacklabs/themis/PublicKey;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Cossacklabs.Themis.PublicKey> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

	}
}

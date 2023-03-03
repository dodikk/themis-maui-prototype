using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Cossacklabs.Themis {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.cossacklabs.themis']/class[@name='SecureServerSocket']"
	[global::Android.Runtime.Register ("com/cossacklabs/themis/SecureServerSocket", DoNotGenerateAcw=true)]
	public partial class SecureServerSocket : global::Java.Net.ServerSocket {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/cossacklabs/themis/SecureServerSocket", typeof (SecureServerSocket));

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

		protected SecureServerSocket (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.cossacklabs.themis']/class[@name='SecureServerSocket']/constructor[@name='SecureServerSocket' and count(parameter)=4 and parameter[1][@type='int'] and parameter[2][@type='byte[]'] and parameter[3][@type='com.cossacklabs.themis.PrivateKey'] and parameter[4][@type='com.cossacklabs.themis.ISessionCallbacks']]"
		[Register (".ctor", "(I[BLcom/cossacklabs/themis/PrivateKey;Lcom/cossacklabs/themis/ISessionCallbacks;)V", "")]
		public unsafe SecureServerSocket (int port, byte[]? id, global::Com.Cossacklabs.Themis.PrivateKey? signPrivateKey, global::Com.Cossacklabs.Themis.ISessionCallbacks? callbacks) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(I[BLcom/cossacklabs/themis/PrivateKey;Lcom/cossacklabs/themis/ISessionCallbacks;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_id = JNIEnv.NewArray (id);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue (port);
				__args [1] = new JniArgumentValue (native_id);
				__args [2] = new JniArgumentValue ((signPrivateKey == null) ? IntPtr.Zero : ((global::Java.Lang.Object) signPrivateKey).Handle);
				__args [3] = new JniArgumentValue ((callbacks == null) ? IntPtr.Zero : ((global::Java.Lang.Object) callbacks).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				if (id != null) {
					JNIEnv.CopyArray (native_id, id);
					JNIEnv.DeleteLocalRef (native_id);
				}
				global::System.GC.KeepAlive (id);
				global::System.GC.KeepAlive (signPrivateKey);
				global::System.GC.KeepAlive (callbacks);
			}
		}

	}
}

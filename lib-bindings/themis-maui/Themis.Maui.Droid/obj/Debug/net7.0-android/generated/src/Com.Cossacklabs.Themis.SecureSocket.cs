using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Cossacklabs.Themis {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.cossacklabs.themis']/class[@name='SecureSocket']"
	[global::Android.Runtime.Register ("com/cossacklabs/themis/SecureSocket", DoNotGenerateAcw=true)]
	public partial class SecureSocket : global::Java.Net.Socket {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/cossacklabs/themis/SecureSocket", typeof (SecureSocket));

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

		protected SecureSocket (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.cossacklabs.themis']/class[@name='SecureSocket']/constructor[@name='SecureSocket' and count(parameter)=3 and parameter[1][@type='byte[]'] and parameter[2][@type='com.cossacklabs.themis.PrivateKey'] and parameter[3][@type='com.cossacklabs.themis.ISessionCallbacks']]"
		[Register (".ctor", "([BLcom/cossacklabs/themis/PrivateKey;Lcom/cossacklabs/themis/ISessionCallbacks;)V", "")]
		public unsafe SecureSocket (byte[]? id, global::Com.Cossacklabs.Themis.PrivateKey? signPrivateKey, global::Com.Cossacklabs.Themis.ISessionCallbacks? callbacks) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "([BLcom/cossacklabs/themis/PrivateKey;Lcom/cossacklabs/themis/ISessionCallbacks;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_id = JNIEnv.NewArray (id);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_id);
				__args [1] = new JniArgumentValue ((signPrivateKey == null) ? IntPtr.Zero : ((global::Java.Lang.Object) signPrivateKey).Handle);
				__args [2] = new JniArgumentValue ((callbacks == null) ? IntPtr.Zero : ((global::Java.Lang.Object) callbacks).Handle);
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

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.cossacklabs.themis']/class[@name='SecureSocket']/constructor[@name='SecureSocket' and count(parameter)=5 and parameter[1][@type='java.net.InetAddress'] and parameter[2][@type='int'] and parameter[3][@type='byte[]'] and parameter[4][@type='com.cossacklabs.themis.PrivateKey'] and parameter[5][@type='com.cossacklabs.themis.ISessionCallbacks']]"
		[Register (".ctor", "(Ljava/net/InetAddress;I[BLcom/cossacklabs/themis/PrivateKey;Lcom/cossacklabs/themis/ISessionCallbacks;)V", "")]
		public unsafe SecureSocket (global::Java.Net.InetAddress? dstAddress, int dstPort, byte[]? id, global::Com.Cossacklabs.Themis.PrivateKey? signPrivateKey, global::Com.Cossacklabs.Themis.ISessionCallbacks? callbacks) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/net/InetAddress;I[BLcom/cossacklabs/themis/PrivateKey;Lcom/cossacklabs/themis/ISessionCallbacks;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_id = JNIEnv.NewArray (id);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [5];
				__args [0] = new JniArgumentValue ((dstAddress == null) ? IntPtr.Zero : ((global::Java.Lang.Object) dstAddress).Handle);
				__args [1] = new JniArgumentValue (dstPort);
				__args [2] = new JniArgumentValue (native_id);
				__args [3] = new JniArgumentValue ((signPrivateKey == null) ? IntPtr.Zero : ((global::Java.Lang.Object) signPrivateKey).Handle);
				__args [4] = new JniArgumentValue ((callbacks == null) ? IntPtr.Zero : ((global::Java.Lang.Object) callbacks).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				if (id != null) {
					JNIEnv.CopyArray (native_id, id);
					JNIEnv.DeleteLocalRef (native_id);
				}
				global::System.GC.KeepAlive (dstAddress);
				global::System.GC.KeepAlive (id);
				global::System.GC.KeepAlive (signPrivateKey);
				global::System.GC.KeepAlive (callbacks);
			}
		}

	}
}

using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Cossacklabs.Themis {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.cossacklabs.themis']/class[@name='SecureTransportSession']"
	[global::Android.Runtime.Register ("com/cossacklabs/themis/SecureTransportSession", DoNotGenerateAcw=true)]
	public partial class SecureTransportSession : global::Com.Cossacklabs.Themis.SecureSession {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/cossacklabs/themis/SecureTransportSession", typeof (SecureTransportSession));

		internal static new IntPtr class_ref {
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

		protected SecureTransportSession (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.cossacklabs.themis']/class[@name='SecureTransportSession']/constructor[@name='SecureTransportSession' and count(parameter)=3 and parameter[1][@type='byte[]'] and parameter[2][@type='com.cossacklabs.themis.PrivateKey'] and parameter[3][@type='com.cossacklabs.themis.ITransportSessionCallbacks']]"
		[Register (".ctor", "([BLcom/cossacklabs/themis/PrivateKey;Lcom/cossacklabs/themis/ITransportSessionCallbacks;)V", "")]
		public unsafe SecureTransportSession (byte[]? id, global::Com.Cossacklabs.Themis.PrivateKey? signPrivateKey, global::Com.Cossacklabs.Themis.ITransportSessionCallbacks? callbacks) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "([BLcom/cossacklabs/themis/PrivateKey;Lcom/cossacklabs/themis/ITransportSessionCallbacks;)V";

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

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.cossacklabs.themis']/class[@name='SecureTransportSession']/constructor[@name='SecureTransportSession' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='com.cossacklabs.themis.PrivateKey'] and parameter[3][@type='com.cossacklabs.themis.ITransportSessionCallbacks']]"
		[Register (".ctor", "(Ljava/lang/String;Lcom/cossacklabs/themis/PrivateKey;Lcom/cossacklabs/themis/ITransportSessionCallbacks;)V", "")]
		public unsafe SecureTransportSession (string? id, global::Com.Cossacklabs.Themis.PrivateKey? signPrivateKey, global::Com.Cossacklabs.Themis.ITransportSessionCallbacks? callbacks) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/lang/String;Lcom/cossacklabs/themis/PrivateKey;Lcom/cossacklabs/themis/ITransportSessionCallbacks;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_id = JNIEnv.NewString ((string?)id);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_id);
				__args [1] = new JniArgumentValue ((signPrivateKey == null) ? IntPtr.Zero : ((global::Java.Lang.Object) signPrivateKey).Handle);
				__args [2] = new JniArgumentValue ((callbacks == null) ? IntPtr.Zero : ((global::Java.Lang.Object) callbacks).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_id);
				global::System.GC.KeepAlive (signPrivateKey);
				global::System.GC.KeepAlive (callbacks);
			}
		}

		static Delegate? cb_connect;
#pragma warning disable 0169
		static Delegate GetConnectHandler ()
		{
			if (cb_connect == null)
				cb_connect = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_Connect);
			return cb_connect;
		}

		static void n_Connect (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Cossacklabs.Themis.SecureTransportSession> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			__this.Connect ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.cossacklabs.themis']/class[@name='SecureTransportSession']/method[@name='connect' and count(parameter)=0]"
		[Register ("connect", "()V", "GetConnectHandler")]
		public virtual unsafe void Connect ()
		{
			const string __id = "connect.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate? cb_read;
#pragma warning disable 0169
		static Delegate GetReadHandler ()
		{
			if (cb_read == null)
				cb_read = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_Read);
			return cb_read;
		}

		static IntPtr n_Read (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Cossacklabs.Themis.SecureTransportSession> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return JNIEnv.NewArray (__this.Read ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.cossacklabs.themis']/class[@name='SecureTransportSession']/method[@name='read' and count(parameter)=0]"
		[Register ("read", "()[B", "GetReadHandler")]
		public virtual unsafe byte[]? Read ()
		{
			const string __id = "read.()[B";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return (byte[]?) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (byte));
			} finally {
			}
		}

		static Delegate? cb_write_arrayB;
#pragma warning disable 0169
		static Delegate GetWrite_arrayBHandler ()
		{
			if (cb_write_arrayB == null)
				cb_write_arrayB = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_Write_arrayB);
			return cb_write_arrayB;
		}

		static void n_Write_arrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_data)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Cossacklabs.Themis.SecureTransportSession> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var data = (byte[]?) JNIEnv.GetArray (native_data, JniHandleOwnership.DoNotTransfer, typeof (byte));
			__this.Write (data);
			if (data != null)
				JNIEnv.CopyArray (data, native_data);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.cossacklabs.themis']/class[@name='SecureTransportSession']/method[@name='write' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("write", "([B)V", "GetWrite_arrayBHandler")]
		public virtual unsafe void Write (byte[]? data)
		{
			const string __id = "write.([B)V";
			IntPtr native_data = JNIEnv.NewArray (data);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_data);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				if (data != null) {
					JNIEnv.CopyArray (native_data, data);
					JNIEnv.DeleteLocalRef (native_data);
				}
				global::System.GC.KeepAlive (data);
			}
		}

	}
}

using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Cossacklabs.Themis {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.cossacklabs.themis']/interface[@name='ITransportSessionCallbacks']"
	[Register ("com/cossacklabs/themis/ITransportSessionCallbacks", "", "Com.Cossacklabs.Themis.ITransportSessionCallbacksInvoker")]
	public partial interface ITransportSessionCallbacks : global::Com.Cossacklabs.Themis.ISessionCallbacks {
		// Metadata.xml XPath method reference: path="/api/package[@name='com.cossacklabs.themis']/interface[@name='ITransportSessionCallbacks']/method[@name='read' and count(parameter)=0]"
		[Register ("read", "()[B", "GetReadHandler:Com.Cossacklabs.Themis.ITransportSessionCallbacksInvoker, Themis.Maui.Droid")]
		byte[]? Read ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.cossacklabs.themis']/interface[@name='ITransportSessionCallbacks']/method[@name='write' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("write", "([B)V", "GetWrite_arrayBHandler:Com.Cossacklabs.Themis.ITransportSessionCallbacksInvoker, Themis.Maui.Droid")]
		void Write (byte[]? p0);

	}

	[global::Android.Runtime.Register ("com/cossacklabs/themis/ITransportSessionCallbacks", DoNotGenerateAcw=true)]
	internal partial class ITransportSessionCallbacksInvoker : global::Java.Lang.Object, ITransportSessionCallbacks {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/cossacklabs/themis/ITransportSessionCallbacks", typeof (ITransportSessionCallbacksInvoker));

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

		public static ITransportSessionCallbacks? GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<ITransportSessionCallbacks> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'com.cossacklabs.themis.ITransportSessionCallbacks'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public ITransportSessionCallbacksInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Cossacklabs.Themis.ITransportSessionCallbacks> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return JNIEnv.NewArray (__this.Read ());
		}
#pragma warning restore 0169

		IntPtr id_read;
		public unsafe byte[]? Read ()
		{
			if (id_read == IntPtr.Zero)
				id_read = JNIEnv.GetMethodID (class_ref, "read", "()[B");
			return (byte[]?) JNIEnv.GetArray (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_read), JniHandleOwnership.TransferLocalRef, typeof (byte));
		}

		static Delegate? cb_write_arrayB;
#pragma warning disable 0169
		static Delegate GetWrite_arrayBHandler ()
		{
			if (cb_write_arrayB == null)
				cb_write_arrayB = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_Write_arrayB);
			return cb_write_arrayB;
		}

		static void n_Write_arrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Cossacklabs.Themis.ITransportSessionCallbacks> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p0 = (byte[]?) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (byte));
			__this.Write (p0);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
		}
#pragma warning restore 0169

		IntPtr id_write_arrayB;
		public unsafe void Write (byte[]? p0)
		{
			if (id_write_arrayB == IntPtr.Zero)
				id_write_arrayB = JNIEnv.GetMethodID (class_ref, "write", "([B)V");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_write_arrayB, __args);
			if (p0 != null) {
				JNIEnv.CopyArray (native_p0, p0);
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate? cb_getPublicKeyForId_Lcom_cossacklabs_themis_SecureSession_arrayB;
#pragma warning disable 0169
		static Delegate GetGetPublicKeyForId_Lcom_cossacklabs_themis_SecureSession_arrayBHandler ()
		{
			if (cb_getPublicKeyForId_Lcom_cossacklabs_themis_SecureSession_arrayB == null)
				cb_getPublicKeyForId_Lcom_cossacklabs_themis_SecureSession_arrayB = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_L) n_GetPublicKeyForId_Lcom_cossacklabs_themis_SecureSession_arrayB);
			return cb_getPublicKeyForId_Lcom_cossacklabs_themis_SecureSession_arrayB;
		}

		static IntPtr n_GetPublicKeyForId_Lcom_cossacklabs_themis_SecureSession_arrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Cossacklabs.Themis.ITransportSessionCallbacks> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p0 = global::Java.Lang.Object.GetObject<global::Com.Cossacklabs.Themis.SecureSession> (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = (byte[]?) JNIEnv.GetArray (native_p1, JniHandleOwnership.DoNotTransfer, typeof (byte));
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetPublicKeyForId (p0, p1));
			if (p1 != null)
				JNIEnv.CopyArray (p1, native_p1);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_getPublicKeyForId_Lcom_cossacklabs_themis_SecureSession_arrayB;
		public unsafe global::Com.Cossacklabs.Themis.PublicKey? GetPublicKeyForId (global::Com.Cossacklabs.Themis.SecureSession? p0, byte[]? p1)
		{
			if (id_getPublicKeyForId_Lcom_cossacklabs_themis_SecureSession_arrayB == IntPtr.Zero)
				id_getPublicKeyForId_Lcom_cossacklabs_themis_SecureSession_arrayB = JNIEnv.GetMethodID (class_ref, "getPublicKeyForId", "(Lcom/cossacklabs/themis/SecureSession;[B)Lcom/cossacklabs/themis/PublicKey;");
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			__args [1] = new JValue (native_p1);
			var __ret = global::Java.Lang.Object.GetObject<global::Com.Cossacklabs.Themis.PublicKey> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getPublicKeyForId_Lcom_cossacklabs_themis_SecureSession_arrayB, __args), JniHandleOwnership.TransferLocalRef);
			if (p1 != null) {
				JNIEnv.CopyArray (native_p1, p1);
				JNIEnv.DeleteLocalRef (native_p1);
			}
			return __ret;
		}

		static Delegate? cb_stateChanged_Lcom_cossacklabs_themis_SecureSession_;
#pragma warning disable 0169
		static Delegate GetStateChanged_Lcom_cossacklabs_themis_SecureSession_Handler ()
		{
			if (cb_stateChanged_Lcom_cossacklabs_themis_SecureSession_ == null)
				cb_stateChanged_Lcom_cossacklabs_themis_SecureSession_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_StateChanged_Lcom_cossacklabs_themis_SecureSession_);
			return cb_stateChanged_Lcom_cossacklabs_themis_SecureSession_;
		}

		static void n_StateChanged_Lcom_cossacklabs_themis_SecureSession_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Cossacklabs.Themis.ITransportSessionCallbacks> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p0 = global::Java.Lang.Object.GetObject<global::Com.Cossacklabs.Themis.SecureSession> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.StateChanged (p0);
		}
#pragma warning restore 0169

		IntPtr id_stateChanged_Lcom_cossacklabs_themis_SecureSession_;
		public unsafe void StateChanged (global::Com.Cossacklabs.Themis.SecureSession? p0)
		{
			if (id_stateChanged_Lcom_cossacklabs_themis_SecureSession_ == IntPtr.Zero)
				id_stateChanged_Lcom_cossacklabs_themis_SecureSession_ = JNIEnv.GetMethodID (class_ref, "stateChanged", "(Lcom/cossacklabs/themis/SecureSession;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_stateChanged_Lcom_cossacklabs_themis_SecureSession_, __args);
		}

	}
}

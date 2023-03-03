using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Cossacklabs.Themis {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.cossacklabs.themis']/class[@name='SecureCellData']"
	[global::Android.Runtime.Register ("com/cossacklabs/themis/SecureCellData", DoNotGenerateAcw=true)]
	public partial class SecureCellData : global::Java.Lang.Object {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/cossacklabs/themis/SecureCellData", typeof (SecureCellData));

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

		protected SecureCellData (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.cossacklabs.themis']/class[@name='SecureCellData']/constructor[@name='SecureCellData' and count(parameter)=2 and parameter[1][@type='byte[]'] and parameter[2][@type='byte[]']]"
		[Register (".ctor", "([B[B)V", "")]
		public unsafe SecureCellData (byte[]? protectedData, byte[]? additionalData) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "([B[B)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_protectedData = JNIEnv.NewArray (protectedData);
			IntPtr native_additionalData = JNIEnv.NewArray (additionalData);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_protectedData);
				__args [1] = new JniArgumentValue (native_additionalData);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				if (protectedData != null) {
					JNIEnv.CopyArray (native_protectedData, protectedData);
					JNIEnv.DeleteLocalRef (native_protectedData);
				}
				if (additionalData != null) {
					JNIEnv.CopyArray (native_additionalData, additionalData);
					JNIEnv.DeleteLocalRef (native_additionalData);
				}
				global::System.GC.KeepAlive (protectedData);
				global::System.GC.KeepAlive (additionalData);
			}
		}

		static Delegate? cb_hasAdditionalData;
#pragma warning disable 0169
		static Delegate GetHasAdditionalDataHandler ()
		{
			if (cb_hasAdditionalData == null)
				cb_hasAdditionalData = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_HasAdditionalData);
			return cb_hasAdditionalData;
		}

		static bool n_HasAdditionalData (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Cossacklabs.Themis.SecureCellData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return __this.HasAdditionalData;
		}
#pragma warning restore 0169

		public virtual unsafe bool HasAdditionalData {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.cossacklabs.themis']/class[@name='SecureCellData']/method[@name='hasAdditionalData' and count(parameter)=0]"
			[Register ("hasAdditionalData", "()Z", "GetHasAdditionalDataHandler")]
			get {
				const string __id = "hasAdditionalData.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate? cb_component1;
#pragma warning disable 0169
		static Delegate GetComponent1Handler ()
		{
			if (cb_component1 == null)
				cb_component1 = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_Component1);
			return cb_component1;
		}

		static IntPtr n_Component1 (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Cossacklabs.Themis.SecureCellData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return JNIEnv.NewArray (__this.Component1 ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.cossacklabs.themis']/class[@name='SecureCellData']/method[@name='component1' and count(parameter)=0]"
		[Register ("component1", "()[B", "GetComponent1Handler")]
		public virtual unsafe byte[] Component1 ()
		{
			const string __id = "component1.()[B";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return (byte[]?) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (byte))!;
			} finally {
			}
		}

		static Delegate? cb_component2;
#pragma warning disable 0169
		static Delegate GetComponent2Handler ()
		{
			if (cb_component2 == null)
				cb_component2 = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_Component2);
			return cb_component2;
		}

		static IntPtr n_Component2 (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Cossacklabs.Themis.SecureCellData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return JNIEnv.NewArray (__this.Component2 ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.cossacklabs.themis']/class[@name='SecureCellData']/method[@name='component2' and count(parameter)=0]"
		[Register ("component2", "()[B", "GetComponent2Handler")]
		public virtual unsafe byte[] Component2 ()
		{
			const string __id = "component2.()[B";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return (byte[]?) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (byte))!;
			} finally {
			}
		}

		static Delegate? cb_getAdditionalData;
#pragma warning disable 0169
		static Delegate GetGetAdditionalDataHandler ()
		{
			if (cb_getAdditionalData == null)
				cb_getAdditionalData = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetAdditionalData);
			return cb_getAdditionalData;
		}

		static IntPtr n_GetAdditionalData (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Cossacklabs.Themis.SecureCellData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return JNIEnv.NewArray (__this.GetAdditionalData ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.cossacklabs.themis']/class[@name='SecureCellData']/method[@name='getAdditionalData' and count(parameter)=0]"
		[Register ("getAdditionalData", "()[B", "GetGetAdditionalDataHandler")]
		public virtual unsafe byte[]? GetAdditionalData ()
		{
			const string __id = "getAdditionalData.()[B";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return (byte[]?) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (byte));
			} finally {
			}
		}

		static Delegate? cb_getProtectedData;
#pragma warning disable 0169
		static Delegate GetGetProtectedDataHandler ()
		{
			if (cb_getProtectedData == null)
				cb_getProtectedData = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetProtectedData);
			return cb_getProtectedData;
		}

		static IntPtr n_GetProtectedData (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Cossacklabs.Themis.SecureCellData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return JNIEnv.NewArray (__this.GetProtectedData ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.cossacklabs.themis']/class[@name='SecureCellData']/method[@name='getProtectedData' and count(parameter)=0]"
		[Register ("getProtectedData", "()[B", "GetGetProtectedDataHandler")]
		public virtual unsafe byte[]? GetProtectedData ()
		{
			const string __id = "getProtectedData.()[B";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return (byte[]?) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (byte));
			} finally {
			}
		}

	}
}

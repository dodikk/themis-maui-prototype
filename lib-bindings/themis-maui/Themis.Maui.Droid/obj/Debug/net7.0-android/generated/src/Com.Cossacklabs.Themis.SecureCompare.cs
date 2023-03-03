using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Cossacklabs.Themis {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.cossacklabs.themis']/class[@name='SecureCompare']"
	[global::Android.Runtime.Register ("com/cossacklabs/themis/SecureCompare", DoNotGenerateAcw=true)]
	public partial class SecureCompare : global::Java.Lang.Object {
		// Metadata.xml XPath class reference: path="/api/package[@name='com.cossacklabs.themis']/class[@name='SecureCompare.CompareResult']"
		[global::Android.Runtime.Register ("com/cossacklabs/themis/SecureCompare$CompareResult", DoNotGenerateAcw=true)]
		public sealed partial class CompareResult : global::Java.Lang.Enum {

			// Metadata.xml XPath field reference: path="/api/package[@name='com.cossacklabs.themis']/class[@name='SecureCompare.CompareResult']/field[@name='MATCH']"
			[Register ("MATCH")]
			public static global::Com.Cossacklabs.Themis.SecureCompare.CompareResult? Match {
				get {
					const string __id = "MATCH.Lcom/cossacklabs/themis/SecureCompare$CompareResult;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Cossacklabs.Themis.SecureCompare.CompareResult> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.cossacklabs.themis']/class[@name='SecureCompare.CompareResult']/field[@name='NOT_READY']"
			[Register ("NOT_READY")]
			public static global::Com.Cossacklabs.Themis.SecureCompare.CompareResult? NotReady {
				get {
					const string __id = "NOT_READY.Lcom/cossacklabs/themis/SecureCompare$CompareResult;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Cossacklabs.Themis.SecureCompare.CompareResult> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.cossacklabs.themis']/class[@name='SecureCompare.CompareResult']/field[@name='NO_MATCH']"
			[Register ("NO_MATCH")]
			public static global::Com.Cossacklabs.Themis.SecureCompare.CompareResult? NoMatch {
				get {
					const string __id = "NO_MATCH.Lcom/cossacklabs/themis/SecureCompare$CompareResult;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Cossacklabs.Themis.SecureCompare.CompareResult> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}

			static readonly JniPeerMembers _members = new XAPeerMembers ("com/cossacklabs/themis/SecureCompare$CompareResult", typeof (CompareResult));

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

			internal CompareResult (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
			{
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.cossacklabs.themis']/class[@name='SecureCompare.CompareResult']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lcom/cossacklabs/themis/SecureCompare$CompareResult;", "")]
			public static unsafe global::Com.Cossacklabs.Themis.SecureCompare.CompareResult? ValueOf (string? name)
			{
				const string __id = "valueOf.(Ljava/lang/String;)Lcom/cossacklabs/themis/SecureCompare$CompareResult;";
				IntPtr native_name = JNIEnv.NewString ((string?)name);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_name);
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Cossacklabs.Themis.SecureCompare.CompareResult> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_name);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.cossacklabs.themis']/class[@name='SecureCompare.CompareResult']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lcom/cossacklabs/themis/SecureCompare$CompareResult;", "")]
			public static unsafe global::Com.Cossacklabs.Themis.SecureCompare.CompareResult[]? Values ()
			{
				const string __id = "values.()[Lcom/cossacklabs/themis/SecureCompare$CompareResult;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return (global::Com.Cossacklabs.Themis.SecureCompare.CompareResult[]?) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Com.Cossacklabs.Themis.SecureCompare.CompareResult));
				} finally {
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.cossacklabs.themis']/class[@name='SecureCompare.ProtocolResult']"
		[global::Android.Runtime.Register ("com/cossacklabs/themis/SecureCompare$ProtocolResult", DoNotGenerateAcw=true)]
		public sealed partial class ProtocolResult : global::Java.Lang.Enum {

			// Metadata.xml XPath field reference: path="/api/package[@name='com.cossacklabs.themis']/class[@name='SecureCompare.ProtocolResult']/field[@name='NO_OUTPUT']"
			[Register ("NO_OUTPUT")]
			public static global::Com.Cossacklabs.Themis.SecureCompare.ProtocolResult? NoOutput {
				get {
					const string __id = "NO_OUTPUT.Lcom/cossacklabs/themis/SecureCompare$ProtocolResult;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Cossacklabs.Themis.SecureCompare.ProtocolResult> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.cossacklabs.themis']/class[@name='SecureCompare.ProtocolResult']/field[@name='SEND_TO_PEER']"
			[Register ("SEND_TO_PEER")]
			public static global::Com.Cossacklabs.Themis.SecureCompare.ProtocolResult? SendToPeer {
				get {
					const string __id = "SEND_TO_PEER.Lcom/cossacklabs/themis/SecureCompare$ProtocolResult;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Cossacklabs.Themis.SecureCompare.ProtocolResult> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}

			static readonly JniPeerMembers _members = new XAPeerMembers ("com/cossacklabs/themis/SecureCompare$ProtocolResult", typeof (ProtocolResult));

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

			internal ProtocolResult (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
			{
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.cossacklabs.themis']/class[@name='SecureCompare.ProtocolResult']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lcom/cossacklabs/themis/SecureCompare$ProtocolResult;", "")]
			public static unsafe global::Com.Cossacklabs.Themis.SecureCompare.ProtocolResult? ValueOf (string? name)
			{
				const string __id = "valueOf.(Ljava/lang/String;)Lcom/cossacklabs/themis/SecureCompare$ProtocolResult;";
				IntPtr native_name = JNIEnv.NewString ((string?)name);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_name);
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Cossacklabs.Themis.SecureCompare.ProtocolResult> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_name);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.cossacklabs.themis']/class[@name='SecureCompare.ProtocolResult']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lcom/cossacklabs/themis/SecureCompare$ProtocolResult;", "")]
			public static unsafe global::Com.Cossacklabs.Themis.SecureCompare.ProtocolResult[]? Values ()
			{
				const string __id = "values.()[Lcom/cossacklabs/themis/SecureCompare$ProtocolResult;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return (global::Com.Cossacklabs.Themis.SecureCompare.ProtocolResult[]?) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Com.Cossacklabs.Themis.SecureCompare.ProtocolResult));
				} finally {
				}
			}

		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/cossacklabs/themis/SecureCompare", typeof (SecureCompare));

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

		protected SecureCompare (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.cossacklabs.themis']/class[@name='SecureCompare']/constructor[@name='SecureCompare' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe SecureCompare () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "()V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), null);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, null);
			} finally {
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.cossacklabs.themis']/class[@name='SecureCompare']/constructor[@name='SecureCompare' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register (".ctor", "([B)V", "")]
		public unsafe SecureCompare (byte[]? secret) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "([B)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_secret = JNIEnv.NewArray (secret);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_secret);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				if (secret != null) {
					JNIEnv.CopyArray (native_secret, secret);
					JNIEnv.DeleteLocalRef (native_secret);
				}
				global::System.GC.KeepAlive (secret);
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.cossacklabs.themis']/class[@name='SecureCompare']/constructor[@name='SecureCompare' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register (".ctor", "(Ljava/lang/String;)V", "")]
		public unsafe SecureCompare (string? password) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

		static Delegate? cb_getResult;
#pragma warning disable 0169
		static Delegate GetGetResultHandler ()
		{
			if (cb_getResult == null)
				cb_getResult = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetResult);
			return cb_getResult;
		}

		static IntPtr n_GetResult (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Cossacklabs.Themis.SecureCompare> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return JNIEnv.ToLocalJniHandle (__this.Result);
		}
#pragma warning restore 0169

		public virtual unsafe global::Com.Cossacklabs.Themis.SecureCompare.CompareResult? Result {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.cossacklabs.themis']/class[@name='SecureCompare']/method[@name='getResult' and count(parameter)=0]"
			[Register ("getResult", "()Lcom/cossacklabs/themis/SecureCompare$CompareResult;", "GetGetResultHandler")]
			get {
				const string __id = "getResult.()Lcom/cossacklabs/themis/SecureCompare$CompareResult;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Cossacklabs.Themis.SecureCompare.CompareResult> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate? cb_appendSecret_arrayB;
#pragma warning disable 0169
		static Delegate GetAppendSecret_arrayBHandler ()
		{
			if (cb_appendSecret_arrayB == null)
				cb_appendSecret_arrayB = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_AppendSecret_arrayB);
			return cb_appendSecret_arrayB;
		}

		static void n_AppendSecret_arrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_secretData)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Cossacklabs.Themis.SecureCompare> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var secretData = (byte[]?) JNIEnv.GetArray (native_secretData, JniHandleOwnership.DoNotTransfer, typeof (byte));
			__this.AppendSecret (secretData);
			if (secretData != null)
				JNIEnv.CopyArray (secretData, native_secretData);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.cossacklabs.themis']/class[@name='SecureCompare']/method[@name='appendSecret' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("appendSecret", "([B)V", "GetAppendSecret_arrayBHandler")]
		public virtual unsafe void AppendSecret (byte[]? secretData)
		{
			const string __id = "appendSecret.([B)V";
			IntPtr native_secretData = JNIEnv.NewArray (secretData);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_secretData);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				if (secretData != null) {
					JNIEnv.CopyArray (native_secretData, secretData);
					JNIEnv.DeleteLocalRef (native_secretData);
				}
				global::System.GC.KeepAlive (secretData);
			}
		}

		static Delegate? cb_begin;
#pragma warning disable 0169
		static Delegate GetBeginHandler ()
		{
			if (cb_begin == null)
				cb_begin = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_Begin);
			return cb_begin;
		}

		static IntPtr n_Begin (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Cossacklabs.Themis.SecureCompare> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return JNIEnv.NewArray (__this.Begin ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.cossacklabs.themis']/class[@name='SecureCompare']/method[@name='begin' and count(parameter)=0]"
		[Register ("begin", "()[B", "GetBeginHandler")]
		public virtual unsafe byte[]? Begin ()
		{
			const string __id = "begin.()[B";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return (byte[]?) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (byte));
			} finally {
			}
		}

		static Delegate? cb_close;
#pragma warning disable 0169
		static Delegate GetCloseHandler ()
		{
			if (cb_close == null)
				cb_close = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_Close);
			return cb_close;
		}

		static void n_Close (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Cossacklabs.Themis.SecureCompare> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			__this.Close ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.cossacklabs.themis']/class[@name='SecureCompare']/method[@name='close' and count(parameter)=0]"
		[Register ("close", "()V", "GetCloseHandler")]
		public virtual unsafe void Close ()
		{
			const string __id = "close.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate? cb_proceed_arrayB;
#pragma warning disable 0169
		static Delegate GetProceed_arrayBHandler ()
		{
			if (cb_proceed_arrayB == null)
				cb_proceed_arrayB = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_Proceed_arrayB);
			return cb_proceed_arrayB;
		}

		static IntPtr n_Proceed_arrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_compareData)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Cossacklabs.Themis.SecureCompare> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var compareData = (byte[]?) JNIEnv.GetArray (native_compareData, JniHandleOwnership.DoNotTransfer, typeof (byte));
			IntPtr __ret = JNIEnv.NewArray (__this.Proceed (compareData));
			if (compareData != null)
				JNIEnv.CopyArray (compareData, native_compareData);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.cossacklabs.themis']/class[@name='SecureCompare']/method[@name='proceed' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("proceed", "([B)[B", "GetProceed_arrayBHandler")]
		public virtual unsafe byte[]? Proceed (byte[]? compareData)
		{
			const string __id = "proceed.([B)[B";
			IntPtr native_compareData = JNIEnv.NewArray (compareData);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_compareData);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return (byte[]?) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (byte));
			} finally {
				if (compareData != null) {
					JNIEnv.CopyArray (native_compareData, compareData);
					JNIEnv.DeleteLocalRef (native_compareData);
				}
				global::System.GC.KeepAlive (compareData);
			}
		}

	}
}

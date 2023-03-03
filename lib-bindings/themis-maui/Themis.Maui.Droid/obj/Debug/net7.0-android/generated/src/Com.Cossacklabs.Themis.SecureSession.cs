using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Cossacklabs.Themis {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.cossacklabs.themis']/class[@name='SecureSession']"
	[global::Android.Runtime.Register ("com/cossacklabs/themis/SecureSession", DoNotGenerateAcw=true)]
	public partial class SecureSession : global::Java.Lang.Object {

		// Metadata.xml XPath field reference: path="/api/package[@name='com.cossacklabs.themis']/class[@name='SecureSession']/field[@name='callbacks']"
		[Register ("callbacks")]
		protected global::Com.Cossacklabs.Themis.ISessionCallbacks? Callbacks {
			get {
				const string __id = "callbacks.Lcom/cossacklabs/themis/ISessionCallbacks;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::Com.Cossacklabs.Themis.ISessionCallbacks> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "callbacks.Lcom/cossacklabs/themis/ISessionCallbacks;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.cossacklabs.themis']/class[@name='SecureSession.SessionDataType']"
		[global::Android.Runtime.Register ("com/cossacklabs/themis/SecureSession$SessionDataType", DoNotGenerateAcw=true)]
		public sealed partial class SessionDataType : global::Java.Lang.Enum {

			// Metadata.xml XPath field reference: path="/api/package[@name='com.cossacklabs.themis']/class[@name='SecureSession.SessionDataType']/field[@name='NO_DATA']"
			[Register ("NO_DATA")]
			public static global::Com.Cossacklabs.Themis.SecureSession.SessionDataType? NoData {
				get {
					const string __id = "NO_DATA.Lcom/cossacklabs/themis/SecureSession$SessionDataType;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Cossacklabs.Themis.SecureSession.SessionDataType> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.cossacklabs.themis']/class[@name='SecureSession.SessionDataType']/field[@name='PROTOCOL_DATA']"
			[Register ("PROTOCOL_DATA")]
			public static global::Com.Cossacklabs.Themis.SecureSession.SessionDataType? ProtocolData {
				get {
					const string __id = "PROTOCOL_DATA.Lcom/cossacklabs/themis/SecureSession$SessionDataType;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Cossacklabs.Themis.SecureSession.SessionDataType> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.cossacklabs.themis']/class[@name='SecureSession.SessionDataType']/field[@name='USER_DATA']"
			[Register ("USER_DATA")]
			public static global::Com.Cossacklabs.Themis.SecureSession.SessionDataType? UserData {
				get {
					const string __id = "USER_DATA.Lcom/cossacklabs/themis/SecureSession$SessionDataType;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Cossacklabs.Themis.SecureSession.SessionDataType> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}

			static readonly JniPeerMembers _members = new XAPeerMembers ("com/cossacklabs/themis/SecureSession$SessionDataType", typeof (SessionDataType));

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

			internal SessionDataType (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
			{
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.cossacklabs.themis']/class[@name='SecureSession.SessionDataType']/method[@name='fromByte' and count(parameter)=1 and parameter[1][@type='byte']]"
			[Register ("fromByte", "(B)Lcom/cossacklabs/themis/SecureSession$SessionDataType;", "")]
			public static unsafe global::Com.Cossacklabs.Themis.SecureSession.SessionDataType? FromByte (sbyte src)
			{
				const string __id = "fromByte.(B)Lcom/cossacklabs/themis/SecureSession$SessionDataType;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (src);
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Cossacklabs.Themis.SecureSession.SessionDataType> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.cossacklabs.themis']/class[@name='SecureSession.SessionDataType']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lcom/cossacklabs/themis/SecureSession$SessionDataType;", "")]
			public static unsafe global::Com.Cossacklabs.Themis.SecureSession.SessionDataType? ValueOf (string? name)
			{
				const string __id = "valueOf.(Ljava/lang/String;)Lcom/cossacklabs/themis/SecureSession$SessionDataType;";
				IntPtr native_name = JNIEnv.NewString ((string?)name);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_name);
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Cossacklabs.Themis.SecureSession.SessionDataType> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_name);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.cossacklabs.themis']/class[@name='SecureSession.SessionDataType']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lcom/cossacklabs/themis/SecureSession$SessionDataType;", "")]
			public static unsafe global::Com.Cossacklabs.Themis.SecureSession.SessionDataType[]? Values ()
			{
				const string __id = "values.()[Lcom/cossacklabs/themis/SecureSession$SessionDataType;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return (global::Com.Cossacklabs.Themis.SecureSession.SessionDataType[]?) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Com.Cossacklabs.Themis.SecureSession.SessionDataType));
				} finally {
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.cossacklabs.themis']/class[@name='SecureSession.State']"
		[global::Android.Runtime.Register ("com/cossacklabs/themis/SecureSession$State", DoNotGenerateAcw=true)]
		public sealed partial class State : global::Java.Lang.Enum {

			// Metadata.xml XPath field reference: path="/api/package[@name='com.cossacklabs.themis']/class[@name='SecureSession.State']/field[@name='ESTABLISHED']"
			[Register ("ESTABLISHED")]
			public static global::Com.Cossacklabs.Themis.SecureSession.State? Established {
				get {
					const string __id = "ESTABLISHED.Lcom/cossacklabs/themis/SecureSession$State;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Cossacklabs.Themis.SecureSession.State> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.cossacklabs.themis']/class[@name='SecureSession.State']/field[@name='IDLE']"
			[Register ("IDLE")]
			public static global::Com.Cossacklabs.Themis.SecureSession.State? Idle {
				get {
					const string __id = "IDLE.Lcom/cossacklabs/themis/SecureSession$State;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Cossacklabs.Themis.SecureSession.State> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.cossacklabs.themis']/class[@name='SecureSession.State']/field[@name='NEGOTIATING']"
			[Register ("NEGOTIATING")]
			public static global::Com.Cossacklabs.Themis.SecureSession.State? Negotiating {
				get {
					const string __id = "NEGOTIATING.Lcom/cossacklabs/themis/SecureSession$State;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Cossacklabs.Themis.SecureSession.State> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}

			static readonly JniPeerMembers _members = new XAPeerMembers ("com/cossacklabs/themis/SecureSession$State", typeof (State));

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

			internal State (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
			{
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.cossacklabs.themis']/class[@name='SecureSession.State']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lcom/cossacklabs/themis/SecureSession$State;", "")]
			public static unsafe global::Com.Cossacklabs.Themis.SecureSession.State? ValueOf (string? name)
			{
				const string __id = "valueOf.(Ljava/lang/String;)Lcom/cossacklabs/themis/SecureSession$State;";
				IntPtr native_name = JNIEnv.NewString ((string?)name);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_name);
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Cossacklabs.Themis.SecureSession.State> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_name);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.cossacklabs.themis']/class[@name='SecureSession.State']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lcom/cossacklabs/themis/SecureSession$State;", "")]
			public static unsafe global::Com.Cossacklabs.Themis.SecureSession.State[]? Values ()
			{
				const string __id = "values.()[Lcom/cossacklabs/themis/SecureSession$State;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return (global::Com.Cossacklabs.Themis.SecureSession.State[]?) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Com.Cossacklabs.Themis.SecureSession.State));
				} finally {
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.cossacklabs.themis']/class[@name='SecureSession.UnwrapResult']"
		[global::Android.Runtime.Register ("com/cossacklabs/themis/SecureSession$UnwrapResult", DoNotGenerateAcw=true)]
		public partial class UnwrapResult : global::Java.Lang.Object {
			static readonly JniPeerMembers _members = new XAPeerMembers ("com/cossacklabs/themis/SecureSession$UnwrapResult", typeof (UnwrapResult));

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

			protected UnwrapResult (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
			{
			}

			static Delegate? cb_getDataType;
#pragma warning disable 0169
			static Delegate GetGetDataTypeHandler ()
			{
				if (cb_getDataType == null)
					cb_getDataType = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetDataType);
				return cb_getDataType;
			}

			static IntPtr n_GetDataType (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Cossacklabs.Themis.SecureSession.UnwrapResult> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return JNIEnv.ToLocalJniHandle (__this.DataType);
			}
#pragma warning restore 0169

			public virtual unsafe global::Com.Cossacklabs.Themis.SecureSession.SessionDataType? DataType {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.cossacklabs.themis']/class[@name='SecureSession.UnwrapResult']/method[@name='getDataType' and count(parameter)=0]"
				[Register ("getDataType", "()Lcom/cossacklabs/themis/SecureSession$SessionDataType;", "GetGetDataTypeHandler")]
				get {
					const string __id = "getDataType.()Lcom/cossacklabs/themis/SecureSession$SessionDataType;";
					try {
						var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
						return global::Java.Lang.Object.GetObject<global::Com.Cossacklabs.Themis.SecureSession.SessionDataType> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
			}

			static Delegate? cb_getData;
#pragma warning disable 0169
			static Delegate GetGetDataHandler ()
			{
				if (cb_getData == null)
					cb_getData = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetData);
				return cb_getData;
			}

			static IntPtr n_GetData (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Cossacklabs.Themis.SecureSession.UnwrapResult> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return JNIEnv.NewArray (__this.GetData ());
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.cossacklabs.themis']/class[@name='SecureSession.UnwrapResult']/method[@name='getData' and count(parameter)=0]"
			[Register ("getData", "()[B", "GetGetDataHandler")]
			public virtual unsafe byte[]? GetData ()
			{
				const string __id = "getData.()[B";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return (byte[]?) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (byte));
				} finally {
				}
			}

		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/cossacklabs/themis/SecureSession", typeof (SecureSession));

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

		protected SecureSession (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.cossacklabs.themis']/class[@name='SecureSession']/constructor[@name='SecureSession' and count(parameter)=3 and parameter[1][@type='byte[]'] and parameter[2][@type='com.cossacklabs.themis.PrivateKey'] and parameter[3][@type='com.cossacklabs.themis.ISessionCallbacks']]"
		[Register (".ctor", "([BLcom/cossacklabs/themis/PrivateKey;Lcom/cossacklabs/themis/ISessionCallbacks;)V", "")]
		public unsafe SecureSession (byte[]? id, global::Com.Cossacklabs.Themis.PrivateKey? signPrivateKey, global::Com.Cossacklabs.Themis.ISessionCallbacks? callbacks) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.cossacklabs.themis']/class[@name='SecureSession']/constructor[@name='SecureSession' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='com.cossacklabs.themis.PrivateKey'] and parameter[3][@type='com.cossacklabs.themis.ISessionCallbacks']]"
		[Register (".ctor", "(Ljava/lang/String;Lcom/cossacklabs/themis/PrivateKey;Lcom/cossacklabs/themis/ISessionCallbacks;)V", "")]
		public unsafe SecureSession (string? id, global::Com.Cossacklabs.Themis.PrivateKey? signPrivateKey, global::Com.Cossacklabs.Themis.ISessionCallbacks? callbacks) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/lang/String;Lcom/cossacklabs/themis/PrivateKey;Lcom/cossacklabs/themis/ISessionCallbacks;)V";

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

		static Delegate? cb_isEstablished;
#pragma warning disable 0169
		static Delegate GetIsEstablishedHandler ()
		{
			if (cb_isEstablished == null)
				cb_isEstablished = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_IsEstablished);
			return cb_isEstablished;
		}

		static bool n_IsEstablished (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Cossacklabs.Themis.SecureSession> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return __this.IsEstablished;
		}
#pragma warning restore 0169

		public virtual unsafe bool IsEstablished {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.cossacklabs.themis']/class[@name='SecureSession']/method[@name='isEstablished' and count(parameter)=0]"
			[Register ("isEstablished", "()Z", "GetIsEstablishedHandler")]
			get {
				const string __id = "isEstablished.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Cossacklabs.Themis.SecureSession> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			__this.Close ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.cossacklabs.themis']/class[@name='SecureSession']/method[@name='close' and count(parameter)=0]"
		[Register ("close", "()V", "GetCloseHandler")]
		public virtual unsafe void Close ()
		{
			const string __id = "close.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate? cb_generateConnectRequest;
#pragma warning disable 0169
		static Delegate GetGenerateConnectRequestHandler ()
		{
			if (cb_generateConnectRequest == null)
				cb_generateConnectRequest = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GenerateConnectRequest);
			return cb_generateConnectRequest;
		}

		static IntPtr n_GenerateConnectRequest (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Cossacklabs.Themis.SecureSession> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return JNIEnv.NewArray (__this.GenerateConnectRequest ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.cossacklabs.themis']/class[@name='SecureSession']/method[@name='generateConnectRequest' and count(parameter)=0]"
		[Register ("generateConnectRequest", "()[B", "GetGenerateConnectRequestHandler")]
		public virtual unsafe byte[]? GenerateConnectRequest ()
		{
			const string __id = "generateConnectRequest.()[B";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return (byte[]?) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (byte));
			} finally {
			}
		}

		static Delegate? cb_getState;
#pragma warning disable 0169
		static Delegate GetGetStateHandler ()
		{
			if (cb_getState == null)
				cb_getState = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetState);
			return cb_getState;
		}

		static IntPtr n_GetState (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Cossacklabs.Themis.SecureSession> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return JNIEnv.ToLocalJniHandle (__this.GetState ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.cossacklabs.themis']/class[@name='SecureSession']/method[@name='getState' and count(parameter)=0]"
		[Register ("getState", "()Lcom/cossacklabs/themis/SecureSession$State;", "GetGetStateHandler")]
		public virtual unsafe global::Com.Cossacklabs.Themis.SecureSession.State? GetState ()
		{
			const string __id = "getState.()Lcom/cossacklabs/themis/SecureSession$State;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Com.Cossacklabs.Themis.SecureSession.State> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.cossacklabs.themis']/class[@name='SecureSession']/method[@name='restore' and count(parameter)=2 and parameter[1][@type='byte[]'] and parameter[2][@type='com.cossacklabs.themis.ISessionCallbacks']]"
		[global::System.Obsolete (@"deprecated")]
		[Register ("restore", "([BLcom/cossacklabs/themis/ISessionCallbacks;)Lcom/cossacklabs/themis/SecureSession;", "")]
		public static unsafe global::Com.Cossacklabs.Themis.SecureSession? Restore (byte[]? state, global::Com.Cossacklabs.Themis.ISessionCallbacks? callbacks)
		{
			const string __id = "restore.([BLcom/cossacklabs/themis/ISessionCallbacks;)Lcom/cossacklabs/themis/SecureSession;";
			IntPtr native_state = JNIEnv.NewArray (state);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_state);
				__args [1] = new JniArgumentValue ((callbacks == null) ? IntPtr.Zero : ((global::Java.Lang.Object) callbacks).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Cossacklabs.Themis.SecureSession> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				if (state != null) {
					JNIEnv.CopyArray (native_state, state);
					JNIEnv.DeleteLocalRef (native_state);
				}
				global::System.GC.KeepAlive (state);
				global::System.GC.KeepAlive (callbacks);
			}
		}

		static Delegate? cb_save;
#pragma warning disable 0169
		[global::System.Obsolete]
		static Delegate GetSaveHandler ()
		{
			if (cb_save == null)
				cb_save = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_Save);
			return cb_save;
		}

		[global::System.Obsolete]
		static IntPtr n_Save (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Cossacklabs.Themis.SecureSession> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return JNIEnv.NewArray (__this.Save ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.cossacklabs.themis']/class[@name='SecureSession']/method[@name='save' and count(parameter)=0]"
		[global::System.Obsolete (@"deprecated")]
		[Register ("save", "()[B", "GetSaveHandler")]
		public virtual unsafe byte[]? Save ()
		{
			const string __id = "save.()[B";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return (byte[]?) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (byte));
			} finally {
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

		static IntPtr n_Unwrap_arrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_wrappedData)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Cossacklabs.Themis.SecureSession> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var wrappedData = (byte[]?) JNIEnv.GetArray (native_wrappedData, JniHandleOwnership.DoNotTransfer, typeof (byte));
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Unwrap (wrappedData));
			if (wrappedData != null)
				JNIEnv.CopyArray (wrappedData, native_wrappedData);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.cossacklabs.themis']/class[@name='SecureSession']/method[@name='unwrap' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("unwrap", "([B)Lcom/cossacklabs/themis/SecureSession$UnwrapResult;", "GetUnwrap_arrayBHandler")]
		public virtual unsafe global::Com.Cossacklabs.Themis.SecureSession.UnwrapResult? Unwrap (byte[]? wrappedData)
		{
			const string __id = "unwrap.([B)Lcom/cossacklabs/themis/SecureSession$UnwrapResult;";
			IntPtr native_wrappedData = JNIEnv.NewArray (wrappedData);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_wrappedData);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Cossacklabs.Themis.SecureSession.UnwrapResult> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				if (wrappedData != null) {
					JNIEnv.CopyArray (native_wrappedData, wrappedData);
					JNIEnv.DeleteLocalRef (native_wrappedData);
				}
				global::System.GC.KeepAlive (wrappedData);
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

		static IntPtr n_Wrap_arrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_data)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Cossacklabs.Themis.SecureSession> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var data = (byte[]?) JNIEnv.GetArray (native_data, JniHandleOwnership.DoNotTransfer, typeof (byte));
			IntPtr __ret = JNIEnv.NewArray (__this.Wrap (data));
			if (data != null)
				JNIEnv.CopyArray (data, native_data);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.cossacklabs.themis']/class[@name='SecureSession']/method[@name='wrap' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("wrap", "([B)[B", "GetWrap_arrayBHandler")]
		public virtual unsafe byte[]? Wrap (byte[]? data)
		{
			const string __id = "wrap.([B)[B";
			IntPtr native_data = JNIEnv.NewArray (data);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_data);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return (byte[]?) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (byte));
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

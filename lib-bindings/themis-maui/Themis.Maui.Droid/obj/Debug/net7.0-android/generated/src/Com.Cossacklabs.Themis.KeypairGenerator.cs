using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Cossacklabs.Themis {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.cossacklabs.themis']/class[@name='KeypairGenerator']"
	[global::Android.Runtime.Register ("com/cossacklabs/themis/KeypairGenerator", DoNotGenerateAcw=true)]
	public abstract partial class KeypairGenerator : global::Java.Lang.Object {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/cossacklabs/themis/KeypairGenerator", typeof (KeypairGenerator));

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

		protected KeypairGenerator (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.cossacklabs.themis']/class[@name='KeypairGenerator']/method[@name='generateKeypair' and count(parameter)=0]"
		[Register ("generateKeypair", "()Lcom/cossacklabs/themis/Keypair;", "")]
		public static unsafe global::Com.Cossacklabs.Themis.Keypair? GenerateKeypair ()
		{
			const string __id = "generateKeypair.()Lcom/cossacklabs/themis/Keypair;";
			try {
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
				return global::Java.Lang.Object.GetObject<global::Com.Cossacklabs.Themis.Keypair> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.cossacklabs.themis']/class[@name='KeypairGenerator']/method[@name='generateKeypair' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("generateKeypair", "(I)Lcom/cossacklabs/themis/Keypair;", "")]
		public static unsafe global::Com.Cossacklabs.Themis.Keypair? GenerateKeypair (int keyType)
		{
			const string __id = "generateKeypair.(I)Lcom/cossacklabs/themis/Keypair;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (keyType);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Cossacklabs.Themis.Keypair> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}

	[global::Android.Runtime.Register ("com/cossacklabs/themis/KeypairGenerator", DoNotGenerateAcw=true)]
	internal partial class KeypairGeneratorInvoker : KeypairGenerator {
		public KeypairGeneratorInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer)
		{
		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/cossacklabs/themis/KeypairGenerator", typeof (KeypairGeneratorInvoker));

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

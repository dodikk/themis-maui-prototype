//
// Auto-generated from generator.cs, do not edit
//
// We keep references to objects, so warning 414 is expected
#pragma warning disable 414
using System;
using System.Drawing;
using System.Diagnostics;
using System.ComponentModel;
using System.Threading.Tasks;
using System.Runtime.Versioning;
using System.Runtime.InteropServices;
using System.Diagnostics.CodeAnalysis;
using UIKit;
using GLKit;
using Metal;
using CoreML;
using MapKit;
using Photos;
using ModelIO;
using Network;
using SceneKit;
using Contacts;
using Security;
using Messages;
using AudioUnit;
using CoreVideo;
using CoreMedia;
using QuickLook;
using CoreImage;
using SpriteKit;
using Foundation;
using CoreMotion;
using ObjCRuntime;
using AddressBook;
using MediaPlayer;
using GameplayKit;
using CoreGraphics;
using CoreLocation;
using AVFoundation;
using NewsstandKit;
using FileProvider;
using CoreAnimation;
using CoreFoundation;
using NetworkExtension;
using MetalPerformanceShadersGraph;
#nullable enable
#if !NET
using NativeHandle = System.IntPtr;
#endif
namespace Themis.iOS {
	[Register("TSCellContextImprint", true)]
	public unsafe partial class TSCellContextImprint : TSCell, INSObjectProtocol {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("TSCellContextImprint");
		public override NativeHandle ClassHandle { get { return class_ptr; } }
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public TSCellContextImprint () : base (NSObjectFlag.Empty)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
			if (IsDirectBinding) {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, global::ObjCRuntime.Selector.GetHandle ("init")), "init");
			} else {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, global::ObjCRuntime.Selector.GetHandle ("init")), "init");
			}
		}

		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected TSCellContextImprint (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal TSCellContextImprint (NativeHandle handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("initWithKey:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public TSCellContextImprint (NSData key)
			: base (NSObjectFlag.Empty)
		{
			var key__handle__ = key!.GetNonNullHandle (nameof (key));
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
			if (IsDirectBinding) {
				InitializeHandle (global::ApiDefinition.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("initWithKey:"), key__handle__), "initWithKey:");
			} else {
				InitializeHandle (global::ApiDefinition.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (this.SuperHandle, Selector.GetHandle ("initWithKey:"), key__handle__), "initWithKey:");
			}
		}
		[Export ("conformsToProtocol:")]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[Preserve (Conditional = true)]
		public new virtual bool ConformsToProtocol (NativeHandle aProtocol)
		{
			if (IsDirectBinding) {
				return global::ApiDefinition.Messaging.bool_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("conformsToProtocol:"), aProtocol);
			} else {
				return global::ApiDefinition.Messaging.bool_objc_msgSendSuper_NativeHandle (this.SuperHandle, Selector.GetHandle ("conformsToProtocol:"), aProtocol);
			}
		}
		[Export ("autorelease")]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[Preserve (Conditional = true)]
		public new virtual NSObject DangerousAutorelease ()
		{
			if (IsDirectBinding) {
				return Runtime.GetNSObject (global::ApiDefinition.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("autorelease")))!;
			} else {
				return Runtime.GetNSObject (global::ApiDefinition.Messaging.NativeHandle_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("autorelease")))!;
			}
		}
		[Export ("release")]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[Preserve (Conditional = true)]
		public new virtual void DangerousRelease ()
		{
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("release"));
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("release"));
			}
		}
		[Export ("retain")]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[Preserve (Conditional = true)]
		public new virtual NSObject DangerousRetain ()
		{
			if (IsDirectBinding) {
				return Runtime.GetNSObject (global::ApiDefinition.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("retain")))!;
			} else {
				return Runtime.GetNSObject (global::ApiDefinition.Messaging.NativeHandle_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("retain")))!;
			}
		}
		[Export ("decrypt:context:error:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSData? Decrypt (NSData message, NSData context, out NSError? error)
		{
			var message__handle__ = message!.GetNonNullHandle (nameof (message));
			var context__handle__ = context!.GetNonNullHandle (nameof (context));
			NativeHandle errorValue = IntPtr.Zero;
			NSData? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<NSData> (global::ApiDefinition.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_ref_NativeHandle (this.Handle, Selector.GetHandle ("decrypt:context:error:"), message__handle__, context__handle__, ref errorValue))!;
			} else {
				ret =  Runtime.GetNSObject<NSData> (global::ApiDefinition.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_NativeHandle_ref_NativeHandle (this.SuperHandle, Selector.GetHandle ("decrypt:context:error:"), message__handle__, context__handle__, ref errorValue))!;
			}
			error = Runtime.GetNSObject<NSError> (errorValue)!;
			return ret!;
		}
		[Export ("decrypt:context:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSData? Decrypt (NSData message, NSData context)
		{
			var message__handle__ = message!.GetNonNullHandle (nameof (message));
			var context__handle__ = context!.GetNonNullHandle (nameof (context));
			if (IsDirectBinding) {
				return  Runtime.GetNSObject<NSData> (global::ApiDefinition.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("decrypt:context:"), message__handle__, context__handle__))!;
			} else {
				return  Runtime.GetNSObject<NSData> (global::ApiDefinition.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_NativeHandle (this.SuperHandle, Selector.GetHandle ("decrypt:context:"), message__handle__, context__handle__))!;
			}
		}
		[Export ("encrypt:context:error:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSData? Encrypt (NSData message, NSData context, out NSError? error)
		{
			var message__handle__ = message!.GetNonNullHandle (nameof (message));
			var context__handle__ = context!.GetNonNullHandle (nameof (context));
			NativeHandle errorValue = IntPtr.Zero;
			NSData? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<NSData> (global::ApiDefinition.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_ref_NativeHandle (this.Handle, Selector.GetHandle ("encrypt:context:error:"), message__handle__, context__handle__, ref errorValue))!;
			} else {
				ret =  Runtime.GetNSObject<NSData> (global::ApiDefinition.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_NativeHandle_ref_NativeHandle (this.SuperHandle, Selector.GetHandle ("encrypt:context:error:"), message__handle__, context__handle__, ref errorValue))!;
			}
			error = Runtime.GetNSObject<NSError> (errorValue)!;
			return ret!;
		}
		[Export ("encrypt:context:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSData? Encrypt (NSData message, NSData context)
		{
			var message__handle__ = message!.GetNonNullHandle (nameof (message));
			var context__handle__ = context!.GetNonNullHandle (nameof (context));
			if (IsDirectBinding) {
				return  Runtime.GetNSObject<NSData> (global::ApiDefinition.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("encrypt:context:"), message__handle__, context__handle__))!;
			} else {
				return  Runtime.GetNSObject<NSData> (global::ApiDefinition.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_NativeHandle (this.SuperHandle, Selector.GetHandle ("encrypt:context:"), message__handle__, context__handle__))!;
			}
		}
		[Export ("hash")]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[Preserve (Conditional = true)]
		public new virtual nuint GetNativeHash ()
		{
			if (IsDirectBinding) {
				return global::ApiDefinition.Messaging.UIntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("hash"));
			} else {
				return global::ApiDefinition.Messaging.UIntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("hash"));
			}
		}
		[Export ("isEqual:")]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[Preserve (Conditional = true)]
		public new virtual bool IsEqual (NSObject anObject)
		{
			var anObject__handle__ = anObject!.GetNonNullHandle (nameof (anObject));
			if (IsDirectBinding) {
				return global::ApiDefinition.Messaging.bool_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("isEqual:"), anObject__handle__);
			} else {
				return global::ApiDefinition.Messaging.bool_objc_msgSendSuper_NativeHandle (this.SuperHandle, Selector.GetHandle ("isEqual:"), anObject__handle__);
			}
		}
		[Export ("isKindOfClass:")]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[Preserve (Conditional = true)]
		public new virtual bool IsKindOfClass (Class aClass)
		{
			var aClass__handle__ = aClass!.GetNonNullHandle (nameof (aClass));
			if (IsDirectBinding) {
				return global::ApiDefinition.Messaging.bool_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("isKindOfClass:"), aClass.Handle);
			} else {
				return global::ApiDefinition.Messaging.bool_objc_msgSendSuper_NativeHandle (this.SuperHandle, Selector.GetHandle ("isKindOfClass:"), aClass.Handle);
			}
		}
		[Export ("isMemberOfClass:")]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[Preserve (Conditional = true)]
		public new virtual bool IsMemberOfClass (Class aClass)
		{
			var aClass__handle__ = aClass!.GetNonNullHandle (nameof (aClass));
			if (IsDirectBinding) {
				return global::ApiDefinition.Messaging.bool_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("isMemberOfClass:"), aClass.Handle);
			} else {
				return global::ApiDefinition.Messaging.bool_objc_msgSendSuper_NativeHandle (this.SuperHandle, Selector.GetHandle ("isMemberOfClass:"), aClass.Handle);
			}
		}
		[Export ("performSelector:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[Preserve (Conditional = true)]
		public new virtual NSObject PerformSelector (Selector aSelector)
		{
			var aSelector__handle__ = aSelector!.GetNonNullHandle (nameof (aSelector));
			if (IsDirectBinding) {
				return Runtime.GetNSObject (global::ApiDefinition.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("performSelector:"), aSelector.Handle))!;
			} else {
				return Runtime.GetNSObject (global::ApiDefinition.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (this.SuperHandle, Selector.GetHandle ("performSelector:"), aSelector.Handle))!;
			}
		}
		[Export ("performSelector:withObject:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[Preserve (Conditional = true)]
		public new virtual NSObject PerformSelector (Selector aSelector, NSObject anObject)
		{
			var aSelector__handle__ = aSelector!.GetNonNullHandle (nameof (aSelector));
			var anObject__handle__ = anObject!.GetNonNullHandle (nameof (anObject));
			if (IsDirectBinding) {
				return Runtime.GetNSObject (global::ApiDefinition.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("performSelector:withObject:"), aSelector.Handle, anObject__handle__))!;
			} else {
				return Runtime.GetNSObject (global::ApiDefinition.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_NativeHandle (this.SuperHandle, Selector.GetHandle ("performSelector:withObject:"), aSelector.Handle, anObject__handle__))!;
			}
		}
		[Export ("performSelector:withObject:withObject:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[Preserve (Conditional = true)]
		public new virtual NSObject PerformSelector (Selector aSelector, NSObject object1, NSObject object2)
		{
			var aSelector__handle__ = aSelector!.GetNonNullHandle (nameof (aSelector));
			var object1__handle__ = object1!.GetNonNullHandle (nameof (object1));
			var object2__handle__ = object2!.GetNonNullHandle (nameof (object2));
			if (IsDirectBinding) {
				return Runtime.GetNSObject (global::ApiDefinition.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("performSelector:withObject:withObject:"), aSelector.Handle, object1__handle__, object2__handle__))!;
			} else {
				return Runtime.GetNSObject (global::ApiDefinition.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_NativeHandle_NativeHandle (this.SuperHandle, Selector.GetHandle ("performSelector:withObject:withObject:"), aSelector.Handle, object1__handle__, object2__handle__))!;
			}
		}
		[Export ("respondsToSelector:")]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[Preserve (Conditional = true)]
		public new virtual bool RespondsToSelector (Selector sel)
		{
			var sel__handle__ = sel!.GetNonNullHandle (nameof (sel));
			if (IsDirectBinding) {
				return global::ApiDefinition.Messaging.bool_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("respondsToSelector:"), sel.Handle);
			} else {
				return global::ApiDefinition.Messaging.bool_objc_msgSendSuper_NativeHandle (this.SuperHandle, Selector.GetHandle ("respondsToSelector:"), sel.Handle);
			}
		}
		[Export ("unwrapData:context:error:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSData? UnwrapData (NSData message, NSData context, out NSError? error)
		{
			var message__handle__ = message!.GetNonNullHandle (nameof (message));
			var context__handle__ = context!.GetNonNullHandle (nameof (context));
			NativeHandle errorValue = IntPtr.Zero;
			NSData? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<NSData> (global::ApiDefinition.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_ref_NativeHandle (this.Handle, Selector.GetHandle ("unwrapData:context:error:"), message__handle__, context__handle__, ref errorValue))!;
			} else {
				ret =  Runtime.GetNSObject<NSData> (global::ApiDefinition.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_NativeHandle_ref_NativeHandle (this.SuperHandle, Selector.GetHandle ("unwrapData:context:error:"), message__handle__, context__handle__, ref errorValue))!;
			}
			error = Runtime.GetNSObject<NSError> (errorValue)!;
			return ret!;
		}
		[Export ("wrapData:context:error:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSData? WrapData (NSData message, NSData context, out NSError? error)
		{
			var message__handle__ = message!.GetNonNullHandle (nameof (message));
			var context__handle__ = context!.GetNonNullHandle (nameof (context));
			NativeHandle errorValue = IntPtr.Zero;
			NSData? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<NSData> (global::ApiDefinition.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_ref_NativeHandle (this.Handle, Selector.GetHandle ("wrapData:context:error:"), message__handle__, context__handle__, ref errorValue))!;
			} else {
				ret =  Runtime.GetNSObject<NSData> (global::ApiDefinition.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_NativeHandle_ref_NativeHandle (this.SuperHandle, Selector.GetHandle ("wrapData:context:error:"), message__handle__, context__handle__, ref errorValue))!;
			}
			error = Runtime.GetNSObject<NSError> (errorValue)!;
			return ret!;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[Preserve (Conditional = true)]
		public virtual Class Class {
			[Export ("class")]
			get {
				if (IsDirectBinding) {
					return Runtime.GetINativeObject<global::ObjCRuntime.Class> (global::ApiDefinition.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("class")), false)!;
				} else {
					return Runtime.GetINativeObject<global::ObjCRuntime.Class> (global::ApiDefinition.Messaging.NativeHandle_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("class")), false)!;
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[Preserve (Conditional = true)]
		public virtual string Description {
			[Export ("description")]
			get {
				if (IsDirectBinding) {
					return CFString.FromHandle (global::ApiDefinition.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("description")))!;
				} else {
					return CFString.FromHandle (global::ApiDefinition.Messaging.NativeHandle_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("description")))!;
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[Preserve (Conditional = true)]
		public virtual bool IsProxy {
			[Export ("isProxy")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("isProxy"));
				} else {
					return global::ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("isProxy"));
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[Preserve (Conditional = true)]
		public virtual nuint RetainCount {
			[Export ("retainCount")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.UIntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("retainCount"));
				} else {
					return global::ApiDefinition.Messaging.UIntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("retainCount"));
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[Preserve (Conditional = true)]
		public virtual NSObject Self {
			[Export ("self")]
			get {
				NSObject? ret;
				if (IsDirectBinding) {
					ret = Runtime.GetNSObject (global::ApiDefinition.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("self")))!;
				} else {
					ret = Runtime.GetNSObject (global::ApiDefinition.Messaging.NativeHandle_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("self")))!;
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[Preserve (Conditional = true)]
		public virtual Class Superclass {
			[Export ("superclass")]
			get {
				if (IsDirectBinding) {
					return Runtime.GetINativeObject<global::ObjCRuntime.Class> (global::ApiDefinition.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("superclass")), false)!;
				} else {
					return Runtime.GetINativeObject<global::ObjCRuntime.Class> (global::ApiDefinition.Messaging.NativeHandle_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("superclass")), false)!;
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[Preserve (Conditional = true)]
		public virtual NSZone Zone {
			[Export ("zone")]
			get {
				if (IsDirectBinding) {
					return Runtime.GetINativeObject<global::Foundation.NSZone> (global::ApiDefinition.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("zone")), false)!;
				} else {
					return Runtime.GetINativeObject<global::Foundation.NSZone> (global::ApiDefinition.Messaging.NativeHandle_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("zone")), false)!;
				}
			}
		}
	} /* class TSCellContextImprint */
}

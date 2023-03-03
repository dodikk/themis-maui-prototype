using System;
using Foundation;
using ObjCRuntime;


//using themis;


namespace Themis.iOS
{
    [Static]
    //[Verify(ConstantsInterfaceAssociation)]
    partial interface Constants
    {
        // extern double themisVersionNumber;
        //[Field("themisVersionNumber", "__Internal")]
        //double themisVersionNumber { get; }
        //
        //// extern const unsigned char[] themisVersionString;
        //[Field("themisVersionString", "__Internal")]
        //byte[] themisVersionString { get; }
    }

    // @interface TSCell : NSObject
    [BaseType(typeof(NSObject))]
    interface TSCell : IDisposable, INativeObject, INSObjectProtocol
    {
        // @property (readonly, nonatomic) NSData * _Nonnull key;
        [Export("key")]
        NSData Key { get; }

        // -(instancetype _Nullable)initWithKey:(NSData * _Nonnull)key;
        [Export("initWithKey:")]
        NativeHandle Constructor(NSData key);
    }

    // @interface TSCellSeal : TSCell
    [BaseType(typeof(TSCell))]
    interface TSCellSeal : IDisposable, INativeObject, INSObjectProtocol
    {
        // -(instancetype _Nullable)initWithKey:(NSData * _Nonnull)key __attribute__((objc_designated_initializer));
        [Export("initWithKey:")]
        [DesignatedInitializer]
        NativeHandle Constructor(NSData key);

        // -(instancetype _Nullable)initWithPassphrase:(NSString * _Nonnull)passphrase;
        [Export("initWithPassphrase:")]
        NativeHandle Constructor(string passphrase);

        // -(instancetype _Nullable)initWithPassphraseData:(NSData * _Nonnull)passphrase;
        [Export("initWithPassphraseData:")]
        NativeHandle ConstructorInitWithPassphraseData(NSData passphrase);

        // -(NSData * _Nullable)encrypt:(NSData * _Nonnull)message context:(NSData * _Nullable)context error:(NSError * _Nullable * _Nullable)error;
        [Export("encrypt:context:error:")]
        [return: NullAllowed]
        NSData Encrypt(NSData message, [NullAllowed] NSData context, [NullAllowed] out NSError error);

        // -(NSData * _Nullable)encrypt:(NSData * _Nonnull)message error:(NSError * _Nullable * _Nullable)error;
        [Export("encrypt:error:")]
        [return: NullAllowed]
        NSData Encrypt(NSData message, [NullAllowed] out NSError error);

        // -(NSData * _Nullable)encrypt:(NSData * _Nonnull)message context:(NSData * _Nullable)context __attribute__((availability(swift, unavailable)));
        //[Unavailable(PlatformName.Swift)]
        [Export("encrypt:context:")]
        [return: NullAllowed]
        NSData Encrypt(NSData message, [NullAllowed] NSData context);

        // -(NSData * _Nullable)encrypt:(NSData * _Nonnull)message __attribute__((availability(swift, unavailable)));
        //[Unavailable(PlatformName.Swift)]
        [Export("encrypt:")]
        [return: NullAllowed]
        NSData Encrypt(NSData message);

        // -(NSData * _Nullable)wrapData:(NSData * _Nonnull)message context:(NSData * _Nullable)context error:(NSError * _Nullable * _Nullable)error __attribute__((deprecated("use 'encrypt:context:error:' instead")));
        [Export("wrapData:context:error:")]
        [return: NullAllowed]
        NSData WrapData(NSData message, [NullAllowed] NSData context, [NullAllowed] out NSError error);

        // -(NSData * _Nullable)wrapData:(NSData * _Nonnull)message error:(NSError * _Nullable * _Nullable)error __attribute__((deprecated("use 'encrypt:error:' instead")));
        [Export("wrapData:error:")]
        [return: NullAllowed]
        NSData WrapData(NSData message, [NullAllowed] out NSError error);

        // -(NSData * _Nullable)decrypt:(NSData * _Nonnull)message context:(NSData * _Nullable)context error:(NSError * _Nullable * _Nullable)error;
        [Export("decrypt:context:error:")]
        [return: NullAllowed]
        NSData Decrypt(NSData message, [NullAllowed] NSData context, [NullAllowed] out NSError error);

        // -(NSData * _Nullable)decrypt:(NSData * _Nonnull)message error:(NSError * _Nullable * _Nullable)error;
        [Export("decrypt:error:")]
        [return: NullAllowed]
        NSData Decrypt(NSData message, [NullAllowed] out NSError error);

        // -(NSData * _Nullable)decrypt:(NSData * _Nonnull)message context:(NSData * _Nullable)context __attribute__((availability(swift, unavailable)));
        //[Unavailable(PlatformName.Swift)]
        [Export("decrypt:context:")]
        [return: NullAllowed]
        NSData Decrypt(NSData message, [NullAllowed] NSData context);

        // -(NSData * _Nullable)decrypt:(NSData * _Nonnull)message __attribute__((availability(swift, unavailable)));
        //[Unavailable(PlatformName.Swift)]
        [Export("decrypt:")]
        [return: NullAllowed]
        NSData Decrypt(NSData message);

        // -(NSData * _Nullable)unwrapData:(NSData * _Nonnull)message context:(NSData * _Nullable)context error:(NSError * _Nullable * _Nullable)error __attribute__((deprecated("use 'decrypt:context:error:' instead")));
        [Export("unwrapData:context:error:")]
        [return: NullAllowed]
        NSData UnwrapData(NSData message, [NullAllowed] NSData context, [NullAllowed] out NSError error);

        // -(NSData * _Nullable)unwrapData:(NSData * _Nonnull)message error:(NSError * _Nullable * _Nullable)error __attribute__((deprecated("use 'decrypt:error:' instead")));
        [Export("unwrapData:error:")]
        [return: NullAllowed]
        NSData UnwrapData(NSData message, [NullAllowed] out NSError error);
    }

    // @interface TSCellTokenEncryptedData : NSObject
    [BaseType(typeof(NSObject))]
    interface TSCellTokenEncryptedData : IDisposable, INativeObject, INSObjectProtocol
    {
        // @property (nonatomic, strong) NSMutableData * _Nonnull cipherText;
        [Export("cipherText", ArgumentSemantic.Strong)]
        NSMutableData CipherText { get; set; }

        // @property (nonatomic, strong) NSMutableData * _Nonnull token;
        [Export("token", ArgumentSemantic.Strong)]
        NSMutableData Token { get; set; }
    }

    // @interface TSCellTokenEncryptedResult : NSObject
    [BaseType(typeof(NSObject))]
    interface TSCellTokenEncryptedResult : IDisposable, INativeObject, INSObjectProtocol
    {
        // @property (readonly, nonatomic) NSData * _Nonnull encrypted;
        [Export("encrypted")]
        NSData Encrypted { get; }

        // @property (readonly, nonatomic) NSData * _Nonnull token;
        [Export("token")]
        NSData Token { get; }

        // @property (readonly, nonatomic) __deprecated_msg("use 'encrypted' instead") NSData * cipherText __attribute__((deprecated("use 'encrypted' instead")));
        [Export("cipherText")]
        NSData CipherText { get; }
    }

    // @interface TSCellToken : TSCell
    [BaseType(typeof(TSCell))]
    interface TSCellToken : IDisposable, INativeObject, INSObjectProtocol
    {
        // -(instancetype _Nullable)initWithKey:(NSData * _Nonnull)key;
        [Export("initWithKey:")]
        NativeHandle Constructor(NSData key);

        // -(TSCellTokenEncryptedResult * _Nullable)encrypt:(NSData * _Nonnull)message context:(NSData * _Nullable)context error:(NSError * _Nullable * _Nullable)error;
        [Export("encrypt:context:error:")]
        [return: NullAllowed]
        TSCellTokenEncryptedResult Encrypt(NSData message, [NullAllowed] NSData context, [NullAllowed] out NSError error);

        // -(TSCellTokenEncryptedResult * _Nullable)encrypt:(NSData * _Nonnull)message error:(NSError * _Nullable * _Nullable)error;
        [Export("encrypt:error:")]
        [return: NullAllowed]
        TSCellTokenEncryptedResult Encrypt(NSData message, [NullAllowed] out NSError error);

        // -(TSCellTokenEncryptedResult * _Nullable)encrypt:(NSData * _Nonnull)message context:(NSData * _Nullable)context __attribute__((availability(swift, unavailable)));
        //[Unavailable(PlatformName.Swift)]
        [Export("encrypt:context:")]
        [return: NullAllowed]
        TSCellTokenEncryptedResult Encrypt(NSData message, [NullAllowed] NSData context);

        // -(TSCellTokenEncryptedResult * _Nullable)encrypt:(NSData * _Nonnull)message __attribute__((availability(swift, unavailable)));
        //[Unavailable(PlatformName.Swift)]
        [Export("encrypt:")]
        [return: NullAllowed]
        TSCellTokenEncryptedResult Encrypt(NSData message);

        // -(TSCellTokenEncryptedData * _Nullable)wrapData:(NSData * _Nonnull)message context:(NSData * _Nullable)context error:(NSError * _Nullable * _Nullable)error __attribute__((deprecated("use 'encrypt:context:error:' instead")));
        [Export("wrapData:context:error:")]
        [return: NullAllowed]
        TSCellTokenEncryptedData WrapData(NSData message, [NullAllowed] NSData context, [NullAllowed] out NSError error);

        // -(TSCellTokenEncryptedData * _Nullable)wrapData:(NSData * _Nonnull)message error:(NSError * _Nullable * _Nullable)error __attribute__((deprecated("use 'encrypt:error:' instead")));
        [Export("wrapData:error:")]
        [return: NullAllowed]
        TSCellTokenEncryptedData WrapData(NSData message, [NullAllowed] out NSError error);

        // -(NSData * _Nullable)decrypt:(NSData * _Nonnull)message token:(NSData * _Nonnull)token context:(NSData * _Nullable)context error:(NSError * _Nullable * _Nullable)error;
        [Export("decrypt:token:context:error:")]
        [return: NullAllowed]
        NSData Decrypt(NSData message, NSData token, [NullAllowed] NSData context, [NullAllowed] out NSError error);

        // -(NSData * _Nullable)decrypt:(NSData * _Nonnull)message token:(NSData * _Nonnull)token error:(NSError * _Nullable * _Nullable)error;
        [Export("decrypt:token:error:")]
        [return: NullAllowed]
        NSData Decrypt(NSData message, NSData token, [NullAllowed] out NSError error);

        // -(NSData * _Nullable)decrypt:(NSData * _Nonnull)message token:(NSData * _Nonnull)token context:(NSData * _Nullable)context __attribute__((availability(swift, unavailable)));
        //[Unavailable(PlatformName.Swift)]
        [Export("decrypt:token:context:")]
        [return: NullAllowed]
        NSData Decrypt(NSData message, NSData token, [NullAllowed] NSData context);

        // -(NSData * _Nullable)decrypt:(NSData * _Nonnull)message token:(NSData * _Nonnull)token __attribute__((availability(swift, unavailable)));
        //[Unavailable(PlatformName.Swift)]
        [Export("decrypt:token:")]
        [return: NullAllowed]
        NSData Decrypt(NSData message, NSData token);

        // -(NSData * _Nullable)unwrapData:(TSCellTokenEncryptedData * _Nonnull)message context:(NSData * _Nullable)context error:(NSError * _Nullable * _Nullable)error __attribute__((deprecated("use 'decrypt:token:context:error:' instead")));
        [Export("unwrapData:context:error:")]
        [return: NullAllowed]
        NSData UnwrapData(TSCellTokenEncryptedData message, [NullAllowed] NSData context, [NullAllowed] out NSError error);

        // -(NSData * _Nullable)unwrapData:(TSCellTokenEncryptedData * _Nonnull)message error:(NSError * _Nullable * _Nullable)error __attribute__((deprecated("use 'decrypt:token:error:' instead")));
        [Export("unwrapData:error:")]
        [return: NullAllowed]
        NSData UnwrapData(TSCellTokenEncryptedData message, [NullAllowed] out NSError error);
    }

    // @interface TSCellContextImprint : TSCell
    [BaseType(typeof(TSCell))]
    interface TSCellContextImprint : IDisposable, INativeObject, INSObjectProtocol
    {
        // -(instancetype _Nullable)initWithKey:(NSData * _Nonnull)key;
        [Export("initWithKey:")]
        NativeHandle Constructor(NSData key);

        // -(NSData * _Nullable)encrypt:(NSData * _Nonnull)message context:(NSData * _Nonnull)context error:(NSError * _Nullable * _Nullable)error;
        [Export("encrypt:context:error:")]
        [return: NullAllowed]
        NSData Encrypt(NSData message, NSData context, [NullAllowed] out NSError error);

        // -(NSData * _Nullable)encrypt:(NSData * _Nonnull)message context:(NSData * _Nonnull)context __attribute__((availability(swift, unavailable)));
        //[Unavailable(PlatformName.Swift)]
        [Export("encrypt:context:")]
        [return: NullAllowed]
        NSData Encrypt(NSData message, NSData context);

        // -(NSData * _Nullable)wrapData:(NSData * _Nonnull)message context:(NSData * _Nonnull)context error:(NSError * _Nullable * _Nullable)error __attribute__((deprecated("use 'encrypt:context:error:' instead")));
        [Export("wrapData:context:error:")]
        [return: NullAllowed]
        NSData WrapData(NSData message, NSData context, [NullAllowed] out NSError error);

        // -(NSData * _Nullable)decrypt:(NSData * _Nonnull)message context:(NSData * _Nonnull)context error:(NSError * _Nullable * _Nullable)error;
        [Export("decrypt:context:error:")]
        [return: NullAllowed]
        NSData Decrypt(NSData message, NSData context, [NullAllowed] out NSError error);

        // -(NSData * _Nullable)decrypt:(NSData * _Nonnull)message context:(NSData * _Nonnull)context __attribute__((availability(swift, unavailable)));
        //[Unavailable(PlatformName.Swift)]
        [Export("decrypt:context:")]
        [return: NullAllowed]
        NSData Decrypt(NSData message, NSData context);

        // -(NSData * _Nullable)unwrapData:(NSData * _Nonnull)message context:(NSData * _Nonnull)context error:(NSError * _Nullable * _Nullable)error __attribute__((deprecated("use 'decrypt:context:error:' instead")));
        [Export("unwrapData:context:error:")]
        [return: NullAllowed]
        NSData UnwrapData(NSData message, NSData context, [NullAllowed] out NSError error);
    }

    // @interface TSKeyGen : NSObject
    [BaseType(typeof(NSObject))]
    interface TSKeyGen : IDisposable, INativeObject, INSObjectProtocol
    {
        // @property (readonly, nonatomic) NSMutableData * _Nonnull privateKey;
        [Export("privateKey")]
        NSMutableData PrivateKey { get; }

        // @property (readonly, nonatomic) NSMutableData * _Nonnull publicKey;
        [Export("publicKey")]
        NSMutableData PublicKey { get; }

        // -(instancetype _Nullable)initWithAlgorithm:(TSKeyGenAsymmetricAlgorithm)algorithm;
        [Export("initWithAlgorithm:")]
        NativeHandle Constructor(TSKeyGenAsymmetricAlgorithm algorithm);
    }

    // @interface TSMessage : NSObject
    [BaseType(typeof(NSObject))]
    interface TSMessage : IDisposable, INativeObject, INSObjectProtocol
    {
        // @property (readonly, nonatomic) NSData * _Nonnull privateKey;
        [Export("privateKey")]
        NSData PrivateKey { get; }

        // @property (readonly, nonatomic) NSData * _Nonnull publicKey;
        [Export("publicKey")]
        NSData PublicKey { get; }

        // @property (readonly, nonatomic) TSMessageMode mode;
        [Export("mode")]
        TSMessageMode Mode { get; }

        // -(instancetype _Nullable)initInEncryptModeWithPrivateKey:(NSData * _Nonnull)privateKey peerPublicKey:(NSData * _Nonnull)peerPublicKey;
        [Export("initInEncryptModeWithPrivateKey:peerPublicKey:")]
        NativeHandle ConstructorInitInEncryptMode(
            NSData privateKey,
            NSData peerPublicKey);

        // -(instancetype _Nullable)initInSignVerifyModeWithPrivateKey:(NSData * _Nullable)privateKey peerPublicKey:(NSData * _Nullable)peerPublicKey;
        [Export("initInSignVerifyModeWithPrivateKey:peerPublicKey:")]
        NativeHandle ConstructorInitInSignVerifyMode(
            [NullAllowed] NSData privateKey,
            [NullAllowed] NSData peerPublicKey);

        // -(NSData * _Nullable)wrapData:(NSData * _Nullable)message error:(NSError * _Nullable * _Nullable)error;
        [Export("wrapData:error:")]
        [return: NullAllowed]
        NSData WrapData([NullAllowed] NSData message, [NullAllowed] out NSError error);

        // -(NSData * _Nullable)unwrapData:(NSData * _Nullable)message error:(NSError * _Nullable * _Nullable)error;
        [Export("unwrapData:error:")]
        [return: NullAllowed]
        NSData UnwrapData([NullAllowed] NSData message, [NullAllowed] out NSError error);
    }

    // @interface TSComparator : NSObject
    [BaseType(typeof(NSObject))]
    interface TSComparator : IDisposable, INativeObject, INSObjectProtocol
    {
        // -(instancetype _Nullable)initWithMessageToCompare:(NSData * _Nonnull)message;
        [Export("initWithMessageToCompare:")]
        NativeHandle Constructor(NSData message);

        // -(NSData * _Nullable)beginCompare:(NSError * _Nullable * _Nullable)error;
        [Export("beginCompare:")]
        [return: NullAllowed]
        NSData BeginCompare([NullAllowed] out NSError error);

        // -(NSData * _Nullable)proceedCompare:(NSData * _Nullable)message error:(NSError * _Nullable * _Nullable)error;
        [Export("proceedCompare:error:")]
        [return: NullAllowed]
        NSData ProceedCompare([NullAllowed] NSData message, [NullAllowed] out NSError error);

        // -(TSComparatorStateType)status;
        [Export("status")]
        //[Verify(MethodToProperty)]
        TSComparatorStateType Status { get; }
    }

    // @interface TSSessionTransportInterface : NSObject
    [BaseType(typeof(NSObject))]
    interface TSSessionTransportInterface : IDisposable, INativeObject, INSObjectProtocol
    {
        // -(void)sendData:(NSData * _Nullable)data error:(NSError * _Nullable * _Nullable)error;
        [Export("sendData:error:")]
        void SendData([NullAllowed] NSData data, [NullAllowed] out NSError error);

        // -(NSData * _Nullable)receiveDataWithError:(NSError * _Nullable * _Nullable)error;
        [Export("receiveDataWithError:")]
        [return: NullAllowed]
        NSData ReceiveDataWithError([NullAllowed] out NSError error);

        // -(NSData * _Nullable)publicKeyFor:(NSData * _Nullable)binaryId error:(NSError * _Nullable * _Nullable)error;
        [Export("publicKeyFor:error:")]
        [return: NullAllowed]
        NSData PublicKeyFor([NullAllowed] NSData binaryId, [NullAllowed] out NSError error);

        // -(secure_session_user_callbacks_t * _Nonnull)callbacks;
        //[Export("callbacks")]
        //[Verify(MethodToProperty)]
        //unsafe secure_session_user_callbacks_t* Callbacks { get; }
    }

    // @interface TSSession : NSObject
    [BaseType(typeof(NSObject))]
    interface TSSession : IDisposable, INativeObject, INSObjectProtocol
    {
        // -(instancetype _Nullable)initWithUserId:(NSData * _Nonnull)userId privateKey:(NSData * _Nonnull)privateKey callbacks:(TSSessionTransportInterface * _Nonnull)callbacks;
        [Export("initWithUserId:privateKey:callbacks:")]
        NativeHandle Constructor(NSData userId, NSData privateKey, TSSessionTransportInterface callbacks);

        // -(NSData * _Nullable)connectRequest:(NSError * _Nullable * _Nullable)error;
        [Export("connectRequest:")]
        [return: NullAllowed]
        NSData ConnectRequest([NullAllowed] out NSError error);

        // -(BOOL)connect:(NSError * _Nullable * _Nullable)error;
        [Export("connect:")]
        bool Connect([NullAllowed] out NSError error);

        // -(NSData * _Nullable)wrapData:(NSData * _Nullable)message error:(NSError * _Nullable * _Nullable)error;
        [Export("wrapData:error:")]
        [return: NullAllowed]
        NSData WrapData([NullAllowed] NSData message, [NullAllowed] out NSError error);

        // -(NSData * _Nullable)unwrapData:(NSData * _Nullable)message error:(NSError * _Nullable * _Nullable)error;
        [Export("unwrapData:error:")]
        [return: NullAllowed]
        NSData UnwrapData([NullAllowed] NSData message, [NullAllowed] out NSError error);

        // -(BOOL)wrapAndSend:(NSData * _Nullable)message error:(NSError * _Nullable * _Nullable)error;
        [Export("wrapAndSend:error:")]
        bool WrapAndSend([NullAllowed] NSData message, [NullAllowed] out NSError error);

        // -(NSData * _Nullable)unwrapAndReceive:(NSUInteger)length error:(NSError * _Nullable * _Nullable)error;
        [Export("unwrapAndReceive:error:")]
        [return: NullAllowed]
        NSData UnwrapAndReceive(nuint length, [NullAllowed] out NSError error);

        // -(BOOL)isSessionEstablished;
        [Export("isSessionEstablished")]
        //[Verify(MethodToProperty)]
        bool IsSessionEstablished { get; }
    }
}
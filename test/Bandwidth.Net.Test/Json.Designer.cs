﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Bandwidth.Net.Test {
    using System;
    using System.Reflection;
    
    
    /// <summary>
    ///    A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public class Json {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        internal Json() {
        }
        
        /// <summary>
        ///    Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Bandwidth.Net.Test.Json", typeof(Json).GetTypeInfo().Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///    Overrides the current thread's CurrentUICulture property for all
        ///    resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///    Looks up a localized string similar to {&quot;balance&quot;: &quot;538.37250&quot;,&quot;accountType&quot;:&quot;pre-pay&quot;}.
        /// </summary>
        public static string Account {
            get {
                return ResourceManager.GetString("Account", resourceCulture);
            }
        }
        
        /// <summary>
        ///    Looks up a localized string similar to [{&quot;id&quot;: &quot;transactionId1&quot;, &quot;time&quot;: &quot;2013-02-21T13:39:09Z&quot;,&quot;amount&quot;: &quot;0.00750&quot;,&quot;type&quot;: &quot;charge&quot;,&quot;units&quot;: &quot;1&quot;,&quot;productType&quot;: &quot;sms-out&quot;,&quot;number&quot;: &quot;1234567890&quot;}].
        /// </summary>
        public static string AccountTransactions {
            get {
                return ResourceManager.GetString("AccountTransactions", resourceCulture);
            }
        }
        
        /// <summary>
        ///    Looks up a localized string similar to {
        ///    &quot;id&quot;: &quot;applicationId&quot;,
        ///    &quot;name&quot;: &quot;MyFirstApp&quot;,
        ///    &quot;incomingCallUrl&quot;: &quot;http://example.com/calls.php&quot;,
        ///    &quot;incomingMessageUrl&quot;: &quot;http://example.com/messages.php&quot;,
        ///    &quot;autoAnswer&quot;: true
        ///  }.
        /// </summary>
        public static string Application {
            get {
                return ResourceManager.GetString("Application", resourceCulture);
            }
        }
        
        /// <summary>
        ///    Looks up a localized string similar to [
        ///  {
        ///    &quot;number&quot;: &quot;{number1}&quot;,
        ///    &quot;nationalNumber&quot;: &quot;{national_number1}&quot;,
        ///    &quot;patternMatch&quot;: &quot;          2 9 &quot;,
        ///    &quot;city&quot;: &quot;CARY&quot;,
        ///    &quot;lata&quot;: &quot;426&quot;,
        ///    &quot;rateCenter&quot;: &quot;CARY&quot;,
        ///    &quot;state&quot;: &quot;NC&quot;,
        ///    &quot;price&quot;: &quot;0.60&quot;
        ///  }].
        /// </summary>
        public static string AvailableNumbers {
            get {
                return ResourceManager.GetString("AvailableNumbers", resourceCulture);
            }
        }
        
        /// <summary>
        ///    Looks up a localized string similar to {
        ///    &quot;id&quot;: &quot;bridgeId&quot;,
        ///    &quot;state&quot;: &quot;completed&quot;,
        ///    &quot;bridgeAudio&quot;: &quot;true&quot;,
        ///    &quot;calls&quot;:&quot;https://.../v1/users/{userId}/bridges/{bridgeId}/calls&quot;,
        ///    &quot;createdTime&quot;: &quot;2013-04-22T13:55:30.279Z&quot;,
        ///    &quot;activatedTime&quot;: &quot;2013-04-22T13:55:30.280Z&quot;,
        ///    &quot;completedTime&quot;: &quot;2013-04-22T13:59:30.122Z&quot;
        ///  }.
        /// </summary>
        public static string Bridge {
            get {
                return ResourceManager.GetString("Bridge", resourceCulture);
            }
        }
        
        /// <summary>
        ///    Looks up a localized string similar to  {
        ///    &quot;activeTime&quot;: &quot;2014-12-19T19:13:20Z&quot;,
        ///    &quot;callbackUrl&quot;: &quot;https://example.com&quot;,
        ///    &quot;chargeableDuration&quot;: 60,
        ///    &quot;direction&quot;: &quot;out&quot;,
        ///    &quot;endTime&quot;: &quot;2014-12-19T19:13:22Z&quot;,
        ///    &quot;events&quot;: &quot;https://.../calls/{callId}/events&quot;,
        ///    &quot;fallbackUrl&quot;: &quot;https://example-fallback.com&quot;,
        ///    &quot;from&quot;: &quot;+1234567890&quot;,
        ///    &quot;id&quot;: &quot;callId&quot;,
        ///    &quot;recordingEnabled&quot;: false,
        ///    &quot;recordings&quot;: &quot;https://.../calls/{callId}/recordings&quot;,
        ///    &quot;startTime&quot;: &quot;2014-12-19T19:13:09Z&quot;,
        ///    &quot;state&quot;: &quot;completed&quot;,
        ///    &quot;to&quot;: &quot;+1234567891&quot;,
        ///   [rest of string was truncated]&quot;;.
        /// </summary>
        public static string Call {
            get {
                return ResourceManager.GetString("Call", resourceCulture);
            }
        }
        
        /// <summary>
        ///    Looks up a localized string similar to {
        ///   &quot;id&quot;: &quot;eventId&quot;,
        ///    &quot;time&quot;: &quot;2012-09-19T13:55:41.343Z&quot;,
        ///    &quot;name&quot;: &quot;create&quot;
        ///  }.
        /// </summary>
        public static string CallEvent {
            get {
                return ResourceManager.GetString("CallEvent", resourceCulture);
            }
        }
        
        /// <summary>
        ///    Looks up a localized string similar to {
        ///  &quot;id&quot;: &quot;gatherId&quot;,
        ///  &quot;state&quot;: &quot;completed&quot;,
        ///  &quot;reason&quot;: &quot;max-digits&quot;,
        ///  &quot;createdTime&quot;: &quot;2014-02-12T19:33:56Z&quot;,
        ///  &quot;completedTime&quot;: &quot;2014-02-12T19:33:59Z&quot;,
        ///  &quot;call&quot;: &quot;https://api.catapult.inetwork.com/v1/users/{userId}/calls/callId&quot;,
        ///  &quot;digits&quot;: &quot;1&quot;
        ///}.
        /// </summary>
        public static string CallGather {
            get {
                return ResourceManager.GetString("CallGather", resourceCulture);
            }
        }
        
        /// <summary>
        ///    Looks up a localized string similar to {
        ///    &quot;endTime&quot;: &quot;2013-02-08T12:06:55.007Z&quot;,
        ///    &quot;id&quot;: &quot;recordingId&quot;,
        ///    &quot;media&quot;: &quot;https://.../v1/users/.../media/{callId}-1.wav&quot;,
        ///    &quot;call&quot;: &quot;https://.../v1/users/.../calls/{callId}&quot;,
        ///    &quot;startTime&quot;: &quot;2013-02-08T12:05:17.807Z&quot;,
        ///    &quot;state&quot;: &quot;complete&quot;
        ///  }.
        /// </summary>
        public static string CallRecording {
            get {
                return ResourceManager.GetString("CallRecording", resourceCulture);
            }
        }
        
        /// <summary>
        ///    Looks up a localized string similar to {
        ///        &quot;chargeableDuration&quot;: 60,
        ///        &quot;id&quot;: &quot;transcriptionId&quot;,
        ///        &quot;state&quot;: &quot;completed&quot;,        
        ///        &quot;time&quot;: &quot;2014-10-09T12:09:16Z&quot;,
        ///        &quot;text&quot;: &quot;{transcription-text}&quot;,
        ///        &quot;textSize&quot;: 3627,
        ///        &quot;textUrl&quot;: &quot;{url-to-full-text}&quot;
        ///    }.
        /// </summary>
        public static string CallTranscription {
            get {
                return ResourceManager.GetString("CallTranscription", resourceCulture);
            }
        }
        
        /// <summary>
        ///    Looks up a localized string similar to {
        ///    &quot;activeMembers&quot;: 0,
        ///    &quot;createdTime&quot;: &quot;2013-07-12T15:22:47-02&quot;,
        ///    &quot;from&quot;: &quot;+19703255647&quot;,
        ///    &quot;id&quot;: &quot;conferenceId&quot;,
        ///    &quot;state&quot;: &quot;created&quot;
        ///}.
        /// </summary>
        public static string Conference {
            get {
                return ResourceManager.GetString("Conference", resourceCulture);
            }
        }
        
        /// <summary>
        ///    Looks up a localized string similar to {
        ///      &quot;addedTime&quot;: &quot;2013-07-12T15:54:47-02&quot;,
        ///      &quot;hold&quot;: false,
        ///      &quot;id&quot;: &quot;memberId&quot;,
        ///      &quot;mute&quot;: false,
        ///      &quot;state&quot;: &quot;active&quot;,
        ///      &quot;joinTone&quot;: false,
        ///      &quot;leavingTone&quot;: false,
        ///      &quot;call&quot;: &quot;https://localhost:8444/v1/users/{userId}/calls/callId1&quot;
        ///  }.
        /// </summary>
        public static string ConferenceMember {
            get {
                return ResourceManager.GetString("ConferenceMember", resourceCulture);
            }
        }
        
        /// <summary>
        ///    Looks up a localized string similar to [
        ///    {
        ///        &quot;number&quot;: &quot;{number1}&quot;,
        ///        &quot;nationalNumber&quot;: &quot;{national_number1}&quot;,
        ///        &quot;price&quot;: &quot;2.00&quot;,
        ///        &quot;location&quot;: &quot;https://.../v1/users/.../phoneNumbers/numberId&quot;
        ///    }].
        /// </summary>
        public static string OrderedNumbers {
            get {
                return ResourceManager.GetString("OrderedNumbers", resourceCulture);
            }
        }
    }
}

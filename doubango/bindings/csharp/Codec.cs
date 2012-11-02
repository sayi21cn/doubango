/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 2.0.8
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */

namespace org.doubango.tinyWRAP {

using System;
using System.Runtime.InteropServices;

public class Codec : IDisposable {
  private HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal Codec(IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new HandleRef(this, cPtr);
  }

  internal static HandleRef getCPtr(Codec obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  ~Codec() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          tinyWRAPPINVOKE.delete_Codec(swigCPtr);
        }
        swigCPtr = new HandleRef(null, IntPtr.Zero);
      }
      GC.SuppressFinalize(this);
    }
  }

  public twrap_media_type_t getMediaType() {
    twrap_media_type_t ret = (twrap_media_type_t)tinyWRAPPINVOKE.Codec_getMediaType(swigCPtr);
    return ret;
  }

  public string getName() {
    string ret = tinyWRAPPINVOKE.Codec_getName(swigCPtr);
    return ret;
  }

  public string getDescription() {
    string ret = tinyWRAPPINVOKE.Codec_getDescription(swigCPtr);
    return ret;
  }

  public string getNegFormat() {
    string ret = tinyWRAPPINVOKE.Codec_getNegFormat(swigCPtr);
    return ret;
  }

  public int getAudioSamplingRate() {
    int ret = tinyWRAPPINVOKE.Codec_getAudioSamplingRate(swigCPtr);
    return ret;
  }

  public int getAudioChannels() {
    int ret = tinyWRAPPINVOKE.Codec_getAudioChannels(swigCPtr);
    return ret;
  }

  public int getAudioPTime() {
    int ret = tinyWRAPPINVOKE.Codec_getAudioPTime(swigCPtr);
    return ret;
  }

}

}

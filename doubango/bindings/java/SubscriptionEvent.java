/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 2.0.8
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */

package org.doubango.tinyWRAP;

public class SubscriptionEvent extends SipEvent {
  private long swigCPtr;

  protected SubscriptionEvent(long cPtr, boolean cMemoryOwn) {
    super(tinyWRAPJNI.SubscriptionEvent_SWIGUpcast(cPtr), cMemoryOwn);
    swigCPtr = cPtr;
  }

  protected static long getCPtr(SubscriptionEvent obj) {
    return (obj == null) ? 0 : obj.swigCPtr;
  }

  protected void finalize() {
    delete();
  }

  public synchronized void delete() {
    if (swigCPtr != 0) {
      if (swigCMemOwn) {
        swigCMemOwn = false;
        tinyWRAPJNI.delete_SubscriptionEvent(swigCPtr);
      }
      swigCPtr = 0;
    }
    super.delete();
  }

  public tsip_subscribe_event_type_t getType() {
    return tsip_subscribe_event_type_t.swigToEnum(tinyWRAPJNI.SubscriptionEvent_getType(swigCPtr, this));
  }

  public SubscriptionSession getSession() {
    long cPtr = tinyWRAPJNI.SubscriptionEvent_getSession(swigCPtr, this);
    return (cPtr == 0) ? null : new SubscriptionSession(cPtr, false);
  }

}

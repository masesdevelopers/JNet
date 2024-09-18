/*
*  Copyright 2024 MASES s.r.l.
*
*  Licensed under the Apache License, Version 2.0 (the "License");
*  you may not use this file except in compliance with the License.
*  You may obtain a copy of the License at
*
*  http://www.apache.org/licenses/LICENSE-2.0
*
*  Unless required by applicable law or agreed to in writing, software
*  distributed under the License is distributed on an "AS IS" BASIS,
*  WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
*  See the License for the specific language governing permissions and
*  limitations under the License.
*
*  Refer to LICENSE for more information.
*/

/*
*  This file is generated by MASES.JNetReflector (ver. 2.5.8.0)
*/

package org.mases.jnet.generated.java.util.function;

public final class IntPredicate implements org.mases.jcobridge.IJCListener, java.util.function.IntPredicate {
    final org.mases.jcobridge.JCListener _internalListener;

    public IntPredicate(String key) throws org.mases.jcobridge.JCNativeException {
        super();
        _internalListener = new org.mases.jcobridge.JCListener(key);
    }

    protected void finalize() throws Throwable {
       super.finalize();
       _internalListener.finalize();
    }

    public synchronized void release() {
       _internalListener.release();
    }
    
    public synchronized void raiseEvent(String eventName) {
       _internalListener.raiseEvent(eventName);
    }
    
    public synchronized void raiseEvent(String eventName, Object e) {
       _internalListener.raiseEvent(eventName, e);
    }
    
    public synchronized void raiseEvent(String eventName, Object e, Object... objects) {
       _internalListener.raiseEvent(eventName, e, objects);
    }
    
    public Object getEventData() {
       return _internalListener.getEventData();
    }
    
    public boolean hasExtraData() {
       return _internalListener.hasExtraData();
    }
    
    public int extraDataLength() {
       return _internalListener.extraDataLength();
    }
    
    public Object[] extraData() {
       return _internalListener.extraData();
    }
    
    public Object getReturnData() {
       return _internalListener.getReturnData();
    }
    
    public void setReturnData(Object retData) {
       _internalListener.setReturnData(retData);
    }

    //@Override
    public boolean test(int arg0) {
        org.mases.jnet.developed.JNetEventResult eventDataExchange;
        raiseEvent("test", eventDataExchange, arg0); Object retVal = getReturnData(); return (boolean)retVal;
    }
    //@Override
    public java.util.function.IntPredicate and(java.util.function.IntPredicate arg0) {
        org.mases.jnet.developed.JNetEventResult eventDataExchange;
        raiseEvent("and", eventDataExchange, arg0); Object retVal; if (!eventDataExchange.getHasOverride()) retVal = java.util.function.IntPredicate.super.and(, arg0); else retVal = eventDataExchange.getReturnData(); return (java.util.function.IntPredicate)retVal;
    }
    //@Override
    public java.util.function.IntPredicate negate() {
        org.mases.jnet.developed.JNetEventResult eventDataExchange;
        raiseEvent("negate", eventDataExchange); Object retVal; if (!eventDataExchange.getHasOverride()) retVal = java.util.function.IntPredicate.super.negate(); else retVal = eventDataExchange.getReturnData(); return (java.util.function.IntPredicate)retVal;
    }
    //@Override
    public java.util.function.IntPredicate or(java.util.function.IntPredicate arg0) {
        org.mases.jnet.developed.JNetEventResult eventDataExchange;
        raiseEvent("or", eventDataExchange, arg0); Object retVal; if (!eventDataExchange.getHasOverride()) retVal = java.util.function.IntPredicate.super.or(, arg0); else retVal = eventDataExchange.getReturnData(); return (java.util.function.IntPredicate)retVal;
    }

}
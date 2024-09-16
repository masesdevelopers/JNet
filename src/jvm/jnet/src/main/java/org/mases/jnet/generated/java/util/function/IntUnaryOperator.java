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

public final class IntUnaryOperator implements org.mases.jcobridge.IJCListener, java.util.function.IntUnaryOperator {
   final org.mases.jcobridge.JCListener _internalListener;

    public IntUnaryOperator(String key) throws org.mases.jcobridge.JCNativeException {
        _internalListener = new org.mases.jcobridge.JCListener(key);
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
    public int applyAsInt(int arg0) {
        raiseEvent("applyAsInt", arg0); Object retVal = getReturnData(); return (int)retVal;
    }
    //@Override
    public java.util.function.IntUnaryOperator andThen(java.util.function.IntUnaryOperator arg0) {
        raiseEvent("andThen", arg0); Object retVal = getReturnData(); return (java.util.function.IntUnaryOperator)retVal;
    }
    //@Override
    public java.util.function.IntUnaryOperator andThenDefault(java.util.function.IntUnaryOperator arg0) {
        return java.util.function.IntUnaryOperator.super.andThen(arg0);
    }
    //@Override
    public java.util.function.IntUnaryOperator compose(java.util.function.IntUnaryOperator arg0) {
        raiseEvent("compose", arg0); Object retVal = getReturnData(); return (java.util.function.IntUnaryOperator)retVal;
    }
    //@Override
    public java.util.function.IntUnaryOperator composeDefault(java.util.function.IntUnaryOperator arg0) {
        return java.util.function.IntUnaryOperator.super.compose(arg0);
    }

}
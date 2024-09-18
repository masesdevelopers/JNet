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

package org.mases.jnet.generated.java.net.http;

public final class WebSocket_Listener implements org.mases.jcobridge.IJCListener, java.net.http.WebSocket.Listener {
    final org.mases.jcobridge.JCListener _internalListener;

    public WebSocket_Listener(String key) throws org.mases.jcobridge.JCNativeException {
        super();
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
    public java.util.concurrent.CompletionStage onBinary(java.net.http.WebSocket arg0, java.nio.ByteBuffer arg1, boolean arg2) {
        org.mases.jnet.developed.JNetEventResult eventDataExchange = new org.mases.jnet.developed.JNetEventResult();
        raiseEvent("onBinary", eventDataExchange, arg0, arg1, arg2); Object retVal; if (!eventDataExchange.getHasOverride()) retVal = java.net.http.WebSocket.Listener.super.onBinary(arg0, arg1, arg2); else retVal = eventDataExchange.getReturnData(); return (java.util.concurrent.CompletionStage)retVal;
    }
    //@Override
    public java.util.concurrent.CompletionStage onBinaryDefault(java.net.http.WebSocket arg0, java.nio.ByteBuffer arg1, boolean arg2)METHOD_STUB_EXTEND_EXCEPTIONS_PLACEHOLDER {
        org.mases.jnet.developed.JNetEventResult eventDataExchange = new org.mases.jnet.developed.JNetEventResult();
        return java.net.http.WebSocket.Listener.super.onBinary(arg0, arg1, arg2);
    }
    //@Override
    public java.util.concurrent.CompletionStage onClose(java.net.http.WebSocket arg0, int arg1, java.lang.String arg2) {
        org.mases.jnet.developed.JNetEventResult eventDataExchange = new org.mases.jnet.developed.JNetEventResult();
        raiseEvent("onClose", eventDataExchange, arg0, arg1, arg2); Object retVal; if (!eventDataExchange.getHasOverride()) retVal = java.net.http.WebSocket.Listener.super.onClose(arg0, arg1, arg2); else retVal = eventDataExchange.getReturnData(); return (java.util.concurrent.CompletionStage)retVal;
    }
    //@Override
    public java.util.concurrent.CompletionStage onCloseDefault(java.net.http.WebSocket arg0, int arg1, java.lang.String arg2)METHOD_STUB_EXTEND_EXCEPTIONS_PLACEHOLDER {
        org.mases.jnet.developed.JNetEventResult eventDataExchange = new org.mases.jnet.developed.JNetEventResult();
        return java.net.http.WebSocket.Listener.super.onClose(arg0, arg1, arg2);
    }
    //@Override
    public java.util.concurrent.CompletionStage onPing(java.net.http.WebSocket arg0, java.nio.ByteBuffer arg1) {
        org.mases.jnet.developed.JNetEventResult eventDataExchange = new org.mases.jnet.developed.JNetEventResult();
        raiseEvent("onPing", eventDataExchange, arg0, arg1); Object retVal; if (!eventDataExchange.getHasOverride()) retVal = java.net.http.WebSocket.Listener.super.onPing(arg0, arg1); else retVal = eventDataExchange.getReturnData(); return (java.util.concurrent.CompletionStage)retVal;
    }
    //@Override
    public java.util.concurrent.CompletionStage onPingDefault(java.net.http.WebSocket arg0, java.nio.ByteBuffer arg1)METHOD_STUB_EXTEND_EXCEPTIONS_PLACEHOLDER {
        org.mases.jnet.developed.JNetEventResult eventDataExchange = new org.mases.jnet.developed.JNetEventResult();
        return java.net.http.WebSocket.Listener.super.onPing(arg0, arg1);
    }
    //@Override
    public java.util.concurrent.CompletionStage onPong(java.net.http.WebSocket arg0, java.nio.ByteBuffer arg1) {
        org.mases.jnet.developed.JNetEventResult eventDataExchange = new org.mases.jnet.developed.JNetEventResult();
        raiseEvent("onPong", eventDataExchange, arg0, arg1); Object retVal; if (!eventDataExchange.getHasOverride()) retVal = java.net.http.WebSocket.Listener.super.onPong(arg0, arg1); else retVal = eventDataExchange.getReturnData(); return (java.util.concurrent.CompletionStage)retVal;
    }
    //@Override
    public java.util.concurrent.CompletionStage onPongDefault(java.net.http.WebSocket arg0, java.nio.ByteBuffer arg1)METHOD_STUB_EXTEND_EXCEPTIONS_PLACEHOLDER {
        org.mases.jnet.developed.JNetEventResult eventDataExchange = new org.mases.jnet.developed.JNetEventResult();
        return java.net.http.WebSocket.Listener.super.onPong(arg0, arg1);
    }
    //@Override
    public java.util.concurrent.CompletionStage onText(java.net.http.WebSocket arg0, java.lang.CharSequence arg1, boolean arg2) {
        org.mases.jnet.developed.JNetEventResult eventDataExchange = new org.mases.jnet.developed.JNetEventResult();
        raiseEvent("onText", eventDataExchange, arg0, arg1, arg2); Object retVal; if (!eventDataExchange.getHasOverride()) retVal = java.net.http.WebSocket.Listener.super.onText(arg0, arg1, arg2); else retVal = eventDataExchange.getReturnData(); return (java.util.concurrent.CompletionStage)retVal;
    }
    //@Override
    public java.util.concurrent.CompletionStage onTextDefault(java.net.http.WebSocket arg0, java.lang.CharSequence arg1, boolean arg2)METHOD_STUB_EXTEND_EXCEPTIONS_PLACEHOLDER {
        org.mases.jnet.developed.JNetEventResult eventDataExchange = new org.mases.jnet.developed.JNetEventResult();
        return java.net.http.WebSocket.Listener.super.onText(arg0, arg1, arg2);
    }
    //@Override
    public void onError(java.net.http.WebSocket arg0, java.lang.Throwable arg1) {
        org.mases.jnet.developed.JNetEventResult eventDataExchange = new org.mases.jnet.developed.JNetEventResult();
        raiseEvent("onError", eventDataExchange, arg0, arg1); if (!eventDataExchange.getHasOverride()) java.net.http.WebSocket.Listener.super.onError(arg0, arg1);
    }
    //@Override
    public void onErrorDefault(java.net.http.WebSocket arg0, java.lang.Throwable arg1)METHOD_STUB_EXTEND_EXCEPTIONS_PLACEHOLDER {
        org.mases.jnet.developed.JNetEventResult eventDataExchange = new org.mases.jnet.developed.JNetEventResult();
        java.net.http.WebSocket.Listener.super.onError(arg0, arg1);
    }
    //@Override
    public void onOpen(java.net.http.WebSocket arg0) {
        org.mases.jnet.developed.JNetEventResult eventDataExchange = new org.mases.jnet.developed.JNetEventResult();
        raiseEvent("onOpen", eventDataExchange, arg0); if (!eventDataExchange.getHasOverride()) java.net.http.WebSocket.Listener.super.onOpen(arg0);
    }
    //@Override
    public void onOpenDefault(java.net.http.WebSocket arg0)METHOD_STUB_EXTEND_EXCEPTIONS_PLACEHOLDER {
        org.mases.jnet.developed.JNetEventResult eventDataExchange = new org.mases.jnet.developed.JNetEventResult();
        java.net.http.WebSocket.Listener.super.onOpen(arg0);
    }

}
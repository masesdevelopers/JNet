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
*  This file is generated by MASES.JNetReflector (ver. 2.5.9.0)
*/

package org.mases.jnet.generated.javax.imageio.event;

public final class IIOReadProgressListener implements org.mases.jcobridge.IJCListener, javax.imageio.event.IIOReadProgressListener {
    final org.mases.jcobridge.JCListener _internalListener;

    public IIOReadProgressListener(String key) throws org.mases.jcobridge.JCNativeException {
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
    public void imageComplete(javax.imageio.ImageReader arg0) {
        org.mases.jnet.developed.JNetEventResult eventDataExchange = new org.mases.jnet.developed.JNetEventResult();
        raiseEvent("imageComplete", eventDataExchange, arg0); if (!eventDataExchange.getHasOverride()) throw new UnsupportedOperationException("The method shall be implemented in .NET side since does not have a default implementation within the JVM");
    }
    //@Override
    public void imageProgress(javax.imageio.ImageReader arg0, float arg1) {
        org.mases.jnet.developed.JNetEventResult eventDataExchange = new org.mases.jnet.developed.JNetEventResult();
        raiseEvent("imageProgress", eventDataExchange, arg0, arg1); if (!eventDataExchange.getHasOverride()) throw new UnsupportedOperationException("The method shall be implemented in .NET side since does not have a default implementation within the JVM");
    }
    //@Override
    public void imageStarted(javax.imageio.ImageReader arg0, int arg1) {
        org.mases.jnet.developed.JNetEventResult eventDataExchange = new org.mases.jnet.developed.JNetEventResult();
        raiseEvent("imageStarted", eventDataExchange, arg0, arg1); if (!eventDataExchange.getHasOverride()) throw new UnsupportedOperationException("The method shall be implemented in .NET side since does not have a default implementation within the JVM");
    }
    //@Override
    public void readAborted(javax.imageio.ImageReader arg0) {
        org.mases.jnet.developed.JNetEventResult eventDataExchange = new org.mases.jnet.developed.JNetEventResult();
        raiseEvent("readAborted", eventDataExchange, arg0); if (!eventDataExchange.getHasOverride()) throw new UnsupportedOperationException("The method shall be implemented in .NET side since does not have a default implementation within the JVM");
    }
    //@Override
    public void sequenceComplete(javax.imageio.ImageReader arg0) {
        org.mases.jnet.developed.JNetEventResult eventDataExchange = new org.mases.jnet.developed.JNetEventResult();
        raiseEvent("sequenceComplete", eventDataExchange, arg0); if (!eventDataExchange.getHasOverride()) throw new UnsupportedOperationException("The method shall be implemented in .NET side since does not have a default implementation within the JVM");
    }
    //@Override
    public void sequenceStarted(javax.imageio.ImageReader arg0, int arg1) {
        org.mases.jnet.developed.JNetEventResult eventDataExchange = new org.mases.jnet.developed.JNetEventResult();
        raiseEvent("sequenceStarted", eventDataExchange, arg0, arg1); if (!eventDataExchange.getHasOverride()) throw new UnsupportedOperationException("The method shall be implemented in .NET side since does not have a default implementation within the JVM");
    }
    //@Override
    public void thumbnailComplete(javax.imageio.ImageReader arg0) {
        org.mases.jnet.developed.JNetEventResult eventDataExchange = new org.mases.jnet.developed.JNetEventResult();
        raiseEvent("thumbnailComplete", eventDataExchange, arg0); if (!eventDataExchange.getHasOverride()) throw new UnsupportedOperationException("The method shall be implemented in .NET side since does not have a default implementation within the JVM");
    }
    //@Override
    public void thumbnailProgress(javax.imageio.ImageReader arg0, float arg1) {
        org.mases.jnet.developed.JNetEventResult eventDataExchange = new org.mases.jnet.developed.JNetEventResult();
        raiseEvent("thumbnailProgress", eventDataExchange, arg0, arg1); if (!eventDataExchange.getHasOverride()) throw new UnsupportedOperationException("The method shall be implemented in .NET side since does not have a default implementation within the JVM");
    }
    //@Override
    public void thumbnailStarted(javax.imageio.ImageReader arg0, int arg1, int arg2) {
        org.mases.jnet.developed.JNetEventResult eventDataExchange = new org.mases.jnet.developed.JNetEventResult();
        raiseEvent("thumbnailStarted", eventDataExchange, arg0, arg1, arg2); if (!eventDataExchange.getHasOverride()) throw new UnsupportedOperationException("The method shall be implemented in .NET side since does not have a default implementation within the JVM");
    }

}
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

package org.mases.jnet.generated.javax.imageio.event;

public final class IIOReadUpdateListener implements org.mases.jcobridge.IJCListener, javax.imageio.event.IIOReadUpdateListener {
    final org.mases.jcobridge.JCListener _internalListener;

    public IIOReadUpdateListener(String key) throws org.mases.jcobridge.JCNativeException {
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
    public void imageUpdate(javax.imageio.ImageReader arg0, java.awt.image.BufferedImage arg1, int arg2, int arg3, int arg4, int arg5, int arg6, int arg7, int[] arg8) {
        raiseEvent("imageUpdate", arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8);
    }
    //@Override
    public void passComplete(javax.imageio.ImageReader arg0, java.awt.image.BufferedImage arg1) {
        raiseEvent("passComplete", arg0, arg1);
    }
    //@Override
    public void passStarted(javax.imageio.ImageReader arg0, java.awt.image.BufferedImage arg1, int arg2, int arg3, int arg4, int arg5, int arg6, int arg7, int arg8, int[] arg9) {
        raiseEvent("passStarted", arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9);
    }
    //@Override
    public void thumbnailPassComplete(javax.imageio.ImageReader arg0, java.awt.image.BufferedImage arg1) {
        raiseEvent("thumbnailPassComplete", arg0, arg1);
    }
    //@Override
    public void thumbnailPassStarted(javax.imageio.ImageReader arg0, java.awt.image.BufferedImage arg1, int arg2, int arg3, int arg4, int arg5, int arg6, int arg7, int arg8, int[] arg9) {
        raiseEvent("thumbnailPassStarted", arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9);
    }
    //@Override
    public void thumbnailUpdate(javax.imageio.ImageReader arg0, java.awt.image.BufferedImage arg1, int arg2, int arg3, int arg4, int arg5, int arg6, int arg7, int[] arg8) {
        raiseEvent("thumbnailUpdate", arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8);
    }

}
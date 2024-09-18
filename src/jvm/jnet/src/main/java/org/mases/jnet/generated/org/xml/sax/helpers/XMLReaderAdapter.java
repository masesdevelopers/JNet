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

package org.mases.jnet.generated.org.xml.sax.helpers;

public final class XMLReaderAdapter extends org.xml.sax.helpers.XMLReaderAdapter implements org.mases.jcobridge.IJCListener {
    final org.mases.jcobridge.JCListener _internalListener;

    public XMLReaderAdapter(String key) throws org.mases.jcobridge.JCNativeException, org.xml.sax.SAXException {
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
    public void characters(char[] arg0, int arg1, int arg2) {
        org.mases.jnet.developed.JNetEventResult eventDataExchange = new org.mases.jnet.developed.JNetEventResult();
        raiseEvent("characters", eventDataExchange, arg0, arg1, arg2); if (!eventDataExchange.getHasOverride()) super.characters(arg0, arg1, arg2);
    }
    //@Override
    public void endDocument() {
        org.mases.jnet.developed.JNetEventResult eventDataExchange = new org.mases.jnet.developed.JNetEventResult();
        raiseEvent("endDocument", eventDataExchange); if (!eventDataExchange.getHasOverride()) super.endDocument();
    }
    //@Override
    public void endElement(java.lang.String arg0, java.lang.String arg1, java.lang.String arg2) {
        org.mases.jnet.developed.JNetEventResult eventDataExchange = new org.mases.jnet.developed.JNetEventResult();
        raiseEvent("endElement", eventDataExchange, arg0, arg1, arg2); if (!eventDataExchange.getHasOverride()) super.endElement(arg0, arg1, arg2);
    }
    //@Override
    public void endPrefixMapping(java.lang.String arg0) {
        org.mases.jnet.developed.JNetEventResult eventDataExchange = new org.mases.jnet.developed.JNetEventResult();
        raiseEvent("endPrefixMapping", eventDataExchange, arg0); if (!eventDataExchange.getHasOverride()) super.endPrefixMapping(arg0);
    }
    //@Override
    public void ignorableWhitespace(char[] arg0, int arg1, int arg2) {
        org.mases.jnet.developed.JNetEventResult eventDataExchange = new org.mases.jnet.developed.JNetEventResult();
        raiseEvent("ignorableWhitespace", eventDataExchange, arg0, arg1, arg2); if (!eventDataExchange.getHasOverride()) super.ignorableWhitespace(arg0, arg1, arg2);
    }
    //@Override
    public void parse(java.lang.String arg0) {
        org.mases.jnet.developed.JNetEventResult eventDataExchange = new org.mases.jnet.developed.JNetEventResult();
        raiseEvent("parse", eventDataExchange, arg0); if (!eventDataExchange.getHasOverride()) super.parse(arg0);
    }
    //@Override
    public void parse(org.xml.sax.InputSource arg0) {
        org.mases.jnet.developed.JNetEventResult eventDataExchange = new org.mases.jnet.developed.JNetEventResult();
        raiseEvent("parse1", eventDataExchange, arg0); if (!eventDataExchange.getHasOverride()) super.parse(arg0);
    }
    //@Override
    public void processingInstruction(java.lang.String arg0, java.lang.String arg1) {
        org.mases.jnet.developed.JNetEventResult eventDataExchange = new org.mases.jnet.developed.JNetEventResult();
        raiseEvent("processingInstruction", eventDataExchange, arg0, arg1); if (!eventDataExchange.getHasOverride()) super.processingInstruction(arg0, arg1);
    }
    //@Override
    public void setDocumentHandler(org.xml.sax.DocumentHandler arg0) {
        org.mases.jnet.developed.JNetEventResult eventDataExchange = new org.mases.jnet.developed.JNetEventResult();
        raiseEvent("setDocumentHandler", eventDataExchange, arg0); if (!eventDataExchange.getHasOverride()) super.setDocumentHandler(arg0);
    }
    //@Override
    public void setDocumentLocator(org.xml.sax.Locator arg0) {
        org.mases.jnet.developed.JNetEventResult eventDataExchange = new org.mases.jnet.developed.JNetEventResult();
        raiseEvent("setDocumentLocator", eventDataExchange, arg0); if (!eventDataExchange.getHasOverride()) super.setDocumentLocator(arg0);
    }
    //@Override
    public void setDTDHandler(org.xml.sax.DTDHandler arg0) {
        org.mases.jnet.developed.JNetEventResult eventDataExchange = new org.mases.jnet.developed.JNetEventResult();
        raiseEvent("setDTDHandler", eventDataExchange, arg0); if (!eventDataExchange.getHasOverride()) super.setDTDHandler(arg0);
    }
    //@Override
    public void setEntityResolver(org.xml.sax.EntityResolver arg0) {
        org.mases.jnet.developed.JNetEventResult eventDataExchange = new org.mases.jnet.developed.JNetEventResult();
        raiseEvent("setEntityResolver", eventDataExchange, arg0); if (!eventDataExchange.getHasOverride()) super.setEntityResolver(arg0);
    }
    //@Override
    public void setErrorHandler(org.xml.sax.ErrorHandler arg0) {
        org.mases.jnet.developed.JNetEventResult eventDataExchange = new org.mases.jnet.developed.JNetEventResult();
        raiseEvent("setErrorHandler", eventDataExchange, arg0); if (!eventDataExchange.getHasOverride()) super.setErrorHandler(arg0);
    }
    //@Override
    public void setLocale(java.util.Locale arg0) {
        org.mases.jnet.developed.JNetEventResult eventDataExchange = new org.mases.jnet.developed.JNetEventResult();
        raiseEvent("setLocale", eventDataExchange, arg0); if (!eventDataExchange.getHasOverride()) super.setLocale(arg0);
    }
    //@Override
    public void skippedEntity(java.lang.String arg0) {
        org.mases.jnet.developed.JNetEventResult eventDataExchange = new org.mases.jnet.developed.JNetEventResult();
        raiseEvent("skippedEntity", eventDataExchange, arg0); if (!eventDataExchange.getHasOverride()) super.skippedEntity(arg0);
    }
    //@Override
    public void startDocument() {
        org.mases.jnet.developed.JNetEventResult eventDataExchange = new org.mases.jnet.developed.JNetEventResult();
        raiseEvent("startDocument", eventDataExchange); if (!eventDataExchange.getHasOverride()) super.startDocument();
    }
    //@Override
    public void startElement(java.lang.String arg0, java.lang.String arg1, java.lang.String arg2, org.xml.sax.Attributes arg3) {
        org.mases.jnet.developed.JNetEventResult eventDataExchange = new org.mases.jnet.developed.JNetEventResult();
        raiseEvent("startElement", eventDataExchange, arg0, arg1, arg2, arg3); if (!eventDataExchange.getHasOverride()) super.startElement(arg0, arg1, arg2, arg3);
    }
    //@Override
    public void startPrefixMapping(java.lang.String arg0, java.lang.String arg1) {
        org.mases.jnet.developed.JNetEventResult eventDataExchange = new org.mases.jnet.developed.JNetEventResult();
        raiseEvent("startPrefixMapping", eventDataExchange, arg0, arg1); if (!eventDataExchange.getHasOverride()) super.startPrefixMapping(arg0, arg1);
    }

}
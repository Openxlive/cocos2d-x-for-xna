/****************************************************************************
Copyright (c) 2010-2012 cocos2d-x.org
Copyright (c) 2008-2009 Jason Booth
Copyright (c) 2011-2012 openxlive.com

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in
all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
THE SOFTWARE.
****************************************************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace cocos2d
{
    public class CCPointObject
    {
        private CCPoint m_tRatio;
        public CCPoint Ratio
        {
            get { return m_tRatio; }
            set { m_tRatio = value; }
        }

        private CCPoint m_tOffset;
        public CCPoint Offset
        {
            get { return m_tOffset; }
            set { m_tOffset = value; }
        }

        private CCNode m_pChild;
        public CCNode Child
        {
            get { return m_pChild; }
            set { m_pChild = value; }
        }

        public static CCPointObject pointWithCCPoint(CCPoint ratio, CCPoint offset)
        {
            CCPointObject pRet = new CCPointObject();
            pRet.initWithCCPoint(ratio, offset);
            //pRet->autorelease();
            return pRet;
        }

        public bool initWithCCPoint(CCPoint ratio, CCPoint offset)
        {
            m_tRatio = ratio;
            m_tOffset = offset;
            m_pChild = null;
            return true;
        }
    }
}

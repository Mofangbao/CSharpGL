﻿using GLM;
using CSharpGL.Objects.SceneElements;
using CSharpGL.Objects.Shaders;
using CSharpGL.UIs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharpGL.Objects.Demos.UIs
{
    /// <summary>
    /// 用一个<see cref="AxisElement"/>绘制一个固定在窗口某处的坐标系。
    /// </summary>
    public class SimpleUIAxis : SceneElementBase, IUILayout, IMVP, IDisposable
    {
        public AxisElement axisElement;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="anchor">the edges of the viewport to which a SimpleUIRect is bound and determines how it is resized with its parent.
        /// <para>something like AnchorStyles.Left | AnchorStyles.Bottom.</para></param>
        /// <param name="margin">the space between viewport and SimpleRect.</param>
        /// <param name="size">Stores width when <see cref="OpenGLUIRect.Anchor"/>.Left & <see cref="OpenGLUIRect.Anchor"/>.Right is <see cref="OpenGLUIRect.Anchor"/>.None.
        /// <para> and height when <see cref="OpenGLUIRect.Anchor"/>.Top & <see cref="OpenGLUIRect.Anchor"/>.Bottom is <see cref="OpenGLUIRect.Anchor"/>.None.</para></param>
        /// <param name="zNear"></param>
        /// <param name="zFar"></param>
        /// <param name="rectColor">default color is red.</param>
        public SimpleUIAxis(IUILayoutParam param, GLColor rectColor = null,
            float radius = 0.3f, float axisLength = 10, int faceCount = 10)
        {
            // 把AxiesElement缩放到恰好放进此UI
            radius = radius / axisLength / 2;
            axisLength = 0.5f;
            this.axisElement = new AxisElement(radius, axisLength, faceCount);

            IUILayout layout = this;
            layout.Param = param;
        }

        protected override void CleanUnmanagedRes()
        {
            this.axisElement.Dispose();

            base.CleanUnmanagedRes();
        }

        #region IUILayout

        public IUILayoutParam Param { get; set; }

        #endregion IUILayout

        protected override void DoInitialize()
        {
            this.axisElement.Initialize();

            this.BeforeRendering += this.GetSimpleUI_BeforeRendering();
            this.AfterRendering += this.GetSimpleUI_AfterRendering();
        }

        protected override void DoRender(RenderEventArgs e)
        {
            this.axisElement.Render(e);
        }

        void IMVP.SetShaderProgram(mat4 mvp)
        {
            IMVP element = this.axisElement as IMVP;
            element.SetShaderProgram(mvp);
        }


        void IMVP.ResetShaderProgram()
        {
            IMVP element = this.axisElement as IMVP;
            element.ResetShaderProgram();
        }

        ShaderProgram IMVP.GetShaderProgram()
        {
            return ((IMVP)this.axisElement).GetShaderProgram();
        }
    }
}

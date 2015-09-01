﻿namespace CSharpGL.Objects.Cameras
{
    /// <summary>
    /// Use this for perspective projection * view matrix.
    /// <para>Typical usage: projection * view * model in GLSL.</para>
    /// </summary>
    public interface IPerspectiveCamera
    {
        /// <summary>
        /// Gets or sets the field of view.
        /// </summary>
        /// <value>
        /// The field of view in radius.
        /// </value>
        double FieldOfView { get; set; }

        /// <summary>
        /// Gets or sets the aspect(width / height).
        /// </summary>
        /// <value>
        /// The aspect.
        /// </value>
        double AspectRatio { get; set; }

        /// <summary>
        /// Gets or sets the near.
        /// </summary>
        /// <value>
        /// The near.
        /// </value>
        double Near { get; set; }

        /// <summary>
        /// Gets or sets the far.
        /// </summary>
        /// <value>
        /// The far.
        /// </value>
        double Far { get; set; }
    }
}

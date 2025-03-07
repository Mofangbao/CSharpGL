﻿using CSharpGL.FileParser._3DSParser.Chunks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpGL.FileParser._3DSParser.ToLegacyOpenGL.ChunkDumpers
{
    public static partial class ChunkDumper
    {
        public static void Dump(this ObjectBlockChunk chunk, ThreeDSModel4LegacyOpenGL model)
        {
            foreach (var item in chunk.Children)
            {
                if(item is TriangularMeshChunk)
                {
                    (item as TriangularMeshChunk).Dump(model);
                }
                else if(item is LightChunk)
                {
                    (item as LightChunk).Dump(model);
                }
                else if (item is CameraChunk)
                {
                    (item as CameraChunk).Dump(model);
                }
                else if (!(item is UndefinedChunk))
                {
                    throw new NotImplementedException(string.Format(
                        "not dumper implemented for {0}", item.GetType()));
                }
            }
        }
    }
}

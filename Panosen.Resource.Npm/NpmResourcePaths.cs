using System;
using System.IO;

namespace Panosen.Resource.Npm
{
    /// <summary>
    /// 资源文件名
    /// </summary>
    public class NpmResourcePaths
    {

        /// <summary>
        /// \.gitattributes
        /// </summary>
        public static string _gitattributes => Path.Combine(".gitattributes");

        /// <summary>
        /// \.gitignore
        /// </summary>
        public static string _gitignore => Path.Combine(".gitignore");
    }
}


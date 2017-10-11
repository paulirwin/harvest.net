// The MIT License(MIT)
//
// Copyright(c) 2016 Steven Atkinson
//
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
//
// The above copyright notice and this permission notice shall be included in all
// copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
// SOFTWARE.
//
// Original license: https://github.com/mrstebo/SnakeCase.JsonNet/blob/master/LICENSE

using System.Text.RegularExpressions;
using Newtonsoft.Json.Serialization;

namespace Harvest.Net.Utils
{
    public class SnakeCaseContractResolver : DefaultContractResolver
    {
        protected override string ResolvePropertyName(string propertyName)
        {
            return GetSnakeCase(propertyName);
        }

        private static string GetSnakeCase(string input)
        {
            if (string.IsNullOrEmpty(input))
                return input;

            var buffer = input;

            buffer = Regex.Replace(buffer, @"([A-Z]+)([A-Z][a-z])", "$1_$2");
            buffer = Regex.Replace(buffer, @"([a-z\d])([A-Z])", "$1_$2");
            buffer = Regex.Replace(buffer, @"-", "_");
            buffer = Regex.Replace(buffer, @"\s", "_");
            buffer = Regex.Replace(buffer, @"__+", "_");
            buffer = buffer.ToLowerInvariant();

            return buffer;
        }
    }
}

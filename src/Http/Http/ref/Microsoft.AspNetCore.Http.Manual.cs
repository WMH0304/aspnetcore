// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

namespace Microsoft.AspNetCore.Http
{
    internal partial class RequestCookieCollection : Microsoft.AspNetCore.Http.IRequestCookieCollection, System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<string, string>>, System.Collections.IEnumerable
    {
        public static readonly Microsoft.AspNetCore.Http.RequestCookieCollection Empty;
        public RequestCookieCollection() { }
        public RequestCookieCollection(System.Collections.Generic.Dictionary<string, string> store) { }
        public RequestCookieCollection(int capacity) { }
        public int Count { get { throw null; } }
        public string this[string key] { get { throw null; } }
        public System.Collections.Generic.ICollection<string> Keys { get { throw null; } }
        public bool ContainsKey(string key) { throw null; }
        public Microsoft.AspNetCore.Http.RequestCookieCollection.Enumerator GetEnumerator() { throw null; }
        public static Microsoft.AspNetCore.Http.RequestCookieCollection Parse(System.Collections.Generic.IList<string> values) { throw null; }
        System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<string, string>> System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.String,System.String>>.GetEnumerator() { throw null; }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { throw null; }
        public bool TryGetValue(string key, out string value) { throw null; }
        public partial struct Enumerator : System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<string, string>>, System.Collections.IEnumerator, System.IDisposable
        {
            internal Enumerator(System.Collections.Generic.Dictionary<string, string>.Enumerator dictionaryEnumerator) { throw null; }
            public System.Collections.Generic.KeyValuePair<string, string> Current { get { throw null; } }
            object System.Collections.IEnumerator.Current { get { throw null; } }
            public void Dispose() { }
            public bool MoveNext() { throw null; }
            public void Reset() { }
        }
    }

    internal partial class ResponseCookies : Microsoft.AspNetCore.Http.IResponseCookies
    {
        public ResponseCookies(Microsoft.AspNetCore.Http.IHeaderDictionary headers, Microsoft.Extensions.ObjectPool.ObjectPool<System.Text.StringBuilder> builderPool) { }
        public void Append(string key, string value) { }
        public void Append(string key, string value, Microsoft.AspNetCore.Http.CookieOptions options) { }
        public void Delete(string key) { }
        public void Delete(string key, Microsoft.AspNetCore.Http.CookieOptions options) { }
    }
}

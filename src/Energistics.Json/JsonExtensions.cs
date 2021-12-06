//----------------------------------------------------------------------- 
// ETP DevKit, 1.2
//
// Copyright 2021 Energistics
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//   
//     http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
//-----------------------------------------------------------------------

using Energistics.Json.Tokens;
using System.Collections.Generic;
using System.Linq;

namespace Energistics.Json
{
    public static class JsonExtensions
    {
        public static IEnumerable<Token> GetTokens(this Token token, string key) => (token as Object).GetTokens(key);

        public static IEnumerable<Token> GetTokens(this Object @object, string key)
        {
            if (@object == null) return Enumerable.Empty<Token>();

            @object.Values.TryGetValue(key, out var value);
            return value;
        }

        public static Token GetToken(this Token token, string key) => token.GetTokens(key)?.FirstOrDefault();

        public static Token GetToken(this Object @object, string key) => @object.GetTokens(key)?.FirstOrDefault();

        public static Token GetToken(this Token token, int index) => (token as Array).GetToken(index);

        public static Token GetToken(this Array array, int index) => array?.Values[index];

        public static Array GetArray(this Token token, string key) => token.GetToken(key) as Array;

        public static string GetValue(this Token token, string key) => (token as Object).GetValue(key);

        public static string GetValue(this Object @object, string key) => @object.GetToken(key).GetValue();

        public static string GetValue(this Token token, int index) => (token as Array).GetValue(index);

        public static string GetValue(this Array array, int index) => array.GetToken(index).GetValue();

        public static string GetValue(this Token token) => token is Scalar v ? v.Value : null;

        public static bool IsContainer(this Token token, string key) => (token as Object).IsObject(key);

        public static bool IsContainer(this Object @object, string key) => @object.GetToken(key).IsContainer();

        public static bool IsContainer(this Token token, int index) => (token as Object).IsContainer(index);

        public static bool IsContainer(this Array array, int index) => array.GetToken(index).IsContainer();

        public static bool IsContainer(this Token token) => token is Container;

        public static bool IsObject(this Token token, string key) => (token as Object).IsObject(key);

        public static bool IsObject(this Object @object, string key) => @object.GetToken(key) is Object;

        public static bool IsObject(this Token token, int index) => (token as Object).IsObject(index);

        public static bool IsObject(this Array array, int index) => array.GetToken(index) is Object;

        public static bool IsArray(this Token token, string key) => (token as Object).IsArray(key);

        public static bool IsArray(this Object @object, string key) => @object.GetToken(key) is Array;

        public static bool IsArray(this Token token, int index) => (token as Object).IsArray(index);

        public static bool IsArray(this Array array, int index) => array.GetToken(index) is Array;

        public static bool IsNull(this Token token, string key) => (token as Object).IsNull(key);

        public static bool IsNull(this Object @object, string key) => @object.GetToken(key) is Null;

        public static bool IsNull(this Token token, int index) => (token as Object).IsNull(index);

        public static bool IsNull(this Array array, int index) => array.GetToken(index) is Null;

        public static bool IsBool(this Token token, string key) => (token as Object).IsBool(key);

        public static bool IsBool(this Object @object, string key) => @object.GetToken(key) is Bool;

        public static bool IsBool(this Token token, int index) => (token as Object).IsBool(index);

        public static bool IsBool(this Array array, int index) => array.GetToken(index) is Bool;

        public static bool IsString(this Token token, string key) => (token as Object).IsString(key);

        public static bool IsString(this Object @object, string key) => @object.GetToken(key) is String;

        public static bool IsString(this Token token, int index) => (token as Object).IsString(index);

        public static bool IsString(this Array array, int index) => array.GetToken(index) is String;

        public static bool IsNumber(this Token token, string key) => (token as Object).IsNumber(key);

        public static bool IsNumber(this Object @object, string key) => @object.GetToken(key) is Number;

        public static bool IsNumber(this Token token, int index) => (token as Object).IsNumber(index);

        public static bool IsNumber(this Array array, int index) => array.GetToken(index) is Number;

        public static bool GetBoolValue(this Token token, string key) => (token as Object).GetBoolValue(key);

        public static bool GetBoolValue(this Object @object, string key) => @object.GetToken(key).GetBoolValue();

        public static bool GetBoolValue(this Token token, int index) => (token as Array).GetBoolValue(index);

        public static bool GetBoolValue(this Array array, int index) => array.GetToken(index).GetBoolValue();

        public static bool GetBoolValue(this Token token) => token is True ? true : default(bool);

        public static int GetIntValue(this Token token, string key) => (token as Object).GetIntValue(key);

        public static int GetIntValue(this Object @object, string key) => @object.GetToken(key).GetIntValue();

        public static int GetIntValue(this Token token, int index) => (token as Array).GetIntValue(index);

        public static int GetIntValue(this Array array, int index) => array.GetToken(index).GetIntValue();

        public static int GetIntValue(this Token token) => token is Number n ? n.GetIntValue() : default(int);

        public static long GetLongValue(this Token token, string key) => (token as Object).GetLongValue(key);

        public static long GetLongValue(this Object @object, string key) => @object.GetToken(key).GetLongValue();

        public static long GetLongValue(this Token token, int index) => (token as Array).GetLongValue(index);

        public static long GetLongValue(this Array array, int index) => array.GetToken(index).GetLongValue();

        public static long GetLongValue(this Token token) => token is Number n ? n.GetLongValue() : default(long);

        public static float GetFloatValue(this Token token, string key) => (token as Object).GetFloatValue(key);

        public static float GetFloatValue(this Object @object, string key) => @object.GetToken(key).GetFloatValue();

        public static float GetFloatValue(this Token token, int index) => (token as Array).GetFloatValue(index);

        public static float GetFloatValue(this Array array, int index) => array.GetToken(index).GetFloatValue();

        public static float GetFloatValue(this Token token) => token is Number n ? n.GetFloatValue() : default(float);

        public static double GetDoubleValue(this Token token, string key) => (token as Object).GetDoubleValue(key);

        public static double GetDoubleValue(this Object @object, string key) => @object.GetToken(key).GetDoubleValue();

        public static double GetDoubleValue(this Token token, int index) => (token as Array).GetDoubleValue(index);

        public static double GetDoubleValue(this Array array, int index) => array.GetToken(index).GetDoubleValue();

        public static double GetDoubleValue(this Token token) => token is Number n ? n.GetDoubleValue() : default(double);
    }
}

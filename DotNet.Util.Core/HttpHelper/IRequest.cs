﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNet.Util.Core.HttpHelper
{
    public interface IRequest
    {
        Task<T> GetAsync<T>(string url) where T:class;
        T Get<T> (string url) where T: class;
        Task<T> GetAsync<T>(string url, IDictionary<string, string>? parameters, IDictionary<string, string>? header) where T : class;
        T Get<T>(string url, IDictionary<string, string>? parameters, IDictionary<string, string>? header) where T : class;
        Task<string> GetStringAsync(string url);
        string GetString(string url);
        Task<string> GetStringAsync(string url,IDictionary<string,string>? parameters,IDictionary<string, string>? header);
        string GetString(string url, IDictionary<string, string>? parameters, IDictionary<string, string>? header);
        Task<T> PostAsync<T>(string url) where T : class;
        T Post<T>(string url) where T : class;
        Task<T> PostAsync<T>(string url, IDictionary<string, string>? parameters, IDictionary<string, string>? header,IDictionary<string,string>? body) where T : class;
        T Post<T>(string url, IDictionary<string, string>? parameters, IDictionary<string, string>? header, IDictionary<string, string> body) where T : class;
        Task<string> PostStringAsync(string url);
        string PostString(string url);
        Task<string> PostStringAsync(string url, IDictionary<string, string>? parameters, IDictionary<string, string>? header, IDictionary<string, string>? body);
        string PostString(string url, IDictionary<string, string>? parameters, IDictionary<string, string>? header, IDictionary<string, string>? body);
        public void SetBaseAddress(string baseAddress);
    }
}

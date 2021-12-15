using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Net.Sockets;
using System.Threading;

namespace MIIPL.Common.Client
{
    public static class SocketsEx
    {
        public static string GetRemoteID(this Socket obj)
        {
            try
            {
               
                return GetIP(obj.RemoteEndPoint) + ": " + GetPort(obj.RemoteEndPoint);
            }
            catch
            {
                return string.Empty;
            }
        }
        public static string GetLocalID(this Socket obj)
        {
            try
            {
               
                return GetIP(obj.LocalEndPoint) + ": " + GetPort(obj.LocalEndPoint);
            }
            catch
            {
                return string.Empty;
            }
        }
        public static string RemoteIP(this Socket obj)
        {
            try
            {
                
                return GetIP(obj.RemoteEndPoint);
            }
            catch
            {
                return string.Empty;
            }
        }
        public static int RemotePort(this Socket obj)
        {
            return GetPort(obj.RemoteEndPoint);
        }
        public static int LocalPort(this Socket obj)
        {
            return GetPort(obj.LocalEndPoint);
        }
        public static string GetIP(EndPoint s)
        {
            
            return ((IPEndPoint)s).Address.ToString();
        }
        public static int GetPort(EndPoint s)
        {
            return ((IPEndPoint)s).Port;
        }
        public static void Shutdown(this Socket obj)
        {
           
            try
            {
                try
                {
                    obj.Disconnect(true);
                }
                finally { }
               obj.Shutdown(SocketShutdown.Both);
            }
            catch (Exception ex)
            {

            }
            try
            {
                obj.Close();
            }
            catch{ }
        }
    }
}

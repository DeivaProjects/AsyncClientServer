﻿using System;

namespace AsyncClientServer.Helper
{
	/// <summary>
	/// Implements methods to send messages to the server
	/// <para>Extends <see cref="SendTo"/>, Implements <see cref="ISendToServer"/></para>
	/// </summary>
	public abstract class SendToServer: SendTo,ISendToServer
	{

		/// <summary>
		/// Send a message to the server
		/// </summary>
		/// <param name="message"></param>
		/// <param name="close"></param>
		public void SendMessage(string message, bool close)
		{
			Byte[] data = CreateByteArray(message);

			SendBytes(data, close);
		}

		/// <summary>
		/// Send an object to server
		/// <para>This object will be serialized using xml</para>
		/// <para>If you want to send your own objects use "SerializableObject" wrapper</para>
		/// </summary>
		/// <param name="anyObj"></param>
		/// <param name="close"></param>
		public void SendObject(SerializableObject anyObj, bool close)
		{
			Byte[] data = CreateByteArray(anyObj);
			SendBytes(data, close);
		}

		/// <summary>
		/// Send a file to server
		/// <para>Simple way of sending large files over sockets</para>
		/// </summary>
		/// <param name="FileLocation"></param>
		/// <param name="RemoteFileLocation"></param>
		/// <param name="close"></param>
		public void SendFile(string FileLocation, string RemoteFileLocation, bool close)
		{
			Byte[] data = CreateByteArray(FileLocation, RemoteFileLocation);
			SendBytes(data, close);
		}

		protected abstract void SendBytes(byte[] msg, bool close);
	}
}
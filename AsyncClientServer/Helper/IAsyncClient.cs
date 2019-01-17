﻿using System;
using AsyncClientServer.Model;

namespace AsyncClientServer.Helper
{
	/// <summary>
	/// Interface for AsyncClient
	/// <para>Implements
	/// <seealso cref="IDisposable"/></para>
	/// </summary>
	public interface IAsyncClient : IDisposable
	{
		event ConnectedHandler Connected;

		event ClientMessageReceivedHandler MessageReceived;

		event ClientMessageSubmittedHandler MessageSubmitted;

		void StartClient(string ipServer, int port);

		void StartClient(string ipServer, int port, int reconnectinSeconds);

		bool IsConnected();

		void Receive();

	}
}

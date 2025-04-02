using System;
using System.Collections;
using System.Data;
using OutSystems.HubEdition.RuntimePlatform;

namespace OutSystems.NssExternalDatabaseExec {

	public interface IssExternalDatabaseExec {

		/// <summary>
		/// Executes Insert, Update and Delete instructions/commands
		/// </summary>
		/// <param name="ssDBConnectionName">Database Connection Name (same name configured in Service Center)</param>
		/// <param name="ssCommand"></param>
		/// <param name="ssErrorMessage"></param>
		void MssExecInsUpdDel(string ssDBConnectionName, string ssCommand, out string ssErrorMessage);

		/// <summary>
		/// Executes SQL queries and returns a JSON with the result
		/// </summary>
		/// <param name="ssDBConnectionName">Database Connection Name (same name configured in Service Center)</param>
		/// <param name="ssQuery"></param>
		/// <param name="ssResult"></param>
		/// <param name="ssErrorMessage"></param>
		void MssExecQuery(string ssDBConnectionName, string ssQuery, out string ssResult, out string ssErrorMessage);

	} // IssExternalDatabaseExec

} // OutSystems.NssExternalDatabaseExec

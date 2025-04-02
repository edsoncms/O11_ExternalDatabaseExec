using System;
using System.Collections;
using System.Data;
using OutSystems.HubEdition.RuntimePlatform;
using OutSystems.RuntimePublic.Db;

namespace OutSystems.NssExternalDatabaseExec {

	public class CssExternalDatabaseExec: IssExternalDatabaseExec {

        /// <summary>
        /// Executes Insert, Update and Delete instructions/commands
        /// </summary>
        /// <param name="ssDBConnectionName"></param>
        /// <param name="ssCommand"></param>
        /// <param name="ssErrorMessage"></param>
        public void MssExecInsUpdDel(string ssDBConnectionName, string ssCommand, out string ssErrorMessage) {
			ssErrorMessage = Utils.ExecInsUpdDel(ssDBConnectionName, ssCommand);
		} // MssExecInsUpdDel

        /// <summary>
        /// Executes SQL queries and returns a JSON with the result
        /// </summary>
        /// <param name="ssDBConnectionName"></param>
        /// <param name="ssQuery"></param>
        /// <param name="ssResult"></param>
        /// <param name="ssErrorMessage"></param>
        public void MssExecQuery(string ssDBConnectionName, string ssQuery, out string ssResult, out string ssErrorMessage) {
            ssErrorMessage = Utils.ExecuteQuery(ssDBConnectionName, ssQuery, out ssResult);
		} // MssExecQuery

	} // CssExternalDatabaseExec

} // OutSystems.NssExternalDatabaseExec


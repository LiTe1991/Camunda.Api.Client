namespace Camunda.Api.Client.VariableInstance
{
    public class VariableInstanceInfo : NamedVariableValue
    {
        /// <summary>
        /// The id of the variable instance.
        /// </summary>
        public string Id;
        /// <summary>
        /// The id of the process definition that this variable instance belongs to.
        /// </summary>
        public string ProcessDefinitionId;
        /// <summary>
        /// The id of the process instance that this variable instance belongs to.
        /// </summary>
        public string ProcessInstanceId;
        /// <summary>
        /// The id of the execution that this variable instance belongs to.
        /// </summary>
        public string ExecutionId;
        /// <summary>
        /// The id of the case instance that this variable instance belongs to.
        /// </summary>
        public string CaseInstanceId;
        /// <summary>
        /// The id of the case execution that this variable instance belongs to.
        /// </summary>
        public string CaseExecutionId;
        /// <summary>
        /// The id of the task that this variable instance belongs to.
        /// </summary>
        public string TaskId;
        /// <summary>
        /// The id of the batch that this variable instance belongs to.
        /// </summary>
        public string BatchId;
        /// <summary>
        /// The id of the activity instance that this variable instance belongs to.
        /// </summary>
        public string ActivityInstanceId;
        /// <summary>
        /// The id of the tenant that this variable instance belongs to.
        /// </summary>
        public string TenantId;
        /// <summary>
        /// An error message in case a Java Serialized Object could not be de-serialized.
        /// </summary>
        public string ErrorMessage;
    }
}

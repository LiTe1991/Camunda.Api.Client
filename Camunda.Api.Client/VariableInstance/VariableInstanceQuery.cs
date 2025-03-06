using Newtonsoft.Json;
using System.Collections.Generic;

namespace Camunda.Api.Client.VariableInstance
{
    public class VariableInstanceQuery : SortableQuery<VariableInstanceSorting, VariableInstanceQuery>
    {
        /// <summary>
        /// Filter by variable instance name.
        /// </summary>
        public string VariableName;
        /// <summary>
        /// Filter by the variable instance name. The parameter can include the wildcard % to express like-strategy such as: starts with (%name), ends with (name%) or contains (%name%).
        /// </summary>
        public string VariableNameLike;
        /// <summary>
        /// Only include variable instances which belong to one of the passed process instance ids.
        /// </summary>
        [JsonProperty("processInstanceIdIn")]
        public List<string> ProcessInstanceId = [];
        /// <summary>
        /// Only include variable instances which belong to one of the passed execution ids.
        /// </summary>
        [JsonProperty("executionIdIn")]
        public List<string> ExecutionId = [];
        /// <summary>
        /// Only include variable instances which belong to one of the passed case instance ids.
        /// </summary>
        [JsonProperty("caseInstanceIdIn")]
        public List<string> CaseInstanceId = [];
        /// <summary>
        /// Only include variable instances which belong to one of the passed case execution ids.
        /// </summary>
        [JsonProperty("caseExecutionIdIn")]
        public List<string> CaseExecutionId = [];
        /// <summary>
        /// Only include variable instances which belong to one of the passed task ids.
        /// </summary>
        [JsonProperty("taskIdIn")]
        public List<string> TaskId = [];
        /// <summary>
        /// Only include variable instances which belong to one of the passed and comma-separated batch ids.
        /// </summary>
        [JsonProperty("batchIdIn")]
        public List<string> BatchId = [];
        /// <summary>
        /// Only include variable instances which belong to one of the passed activity instance ids.
        /// </summary>
        [JsonProperty("activityInstanceIdIn")]
        public List<string> ActivityInstanceId = [];
        /// <summary>
        /// Only select variable instances with one of the given tenant ids.
        /// </summary>
        [JsonProperty("tenantIdIn")]
        public List<string> TenantIds = [];
        /// <summary>
        /// An array to only include variable instances that have the certain values.
        /// </summary>
        public List<VariableQueryParameter> VariableValues;
        /// <summary>
        /// Match the variable name provided in taskVariables and processVariables case-insensitively. If set to true variableName and variablename are treated as equal.
        /// </summary>
        [JsonProperty("variableNamesIgnoreCase")]
        public bool? VariableNamesIgnoreCase;

        /// <summary>
        /// Match the variable value provided in taskVariables and processVariables case-insensitively. If set to true variableValue and variablevalue are treated as equal.
        /// </summary>
        [JsonProperty("variableValuesIgnoreCase")]
        public bool? VariableValuesIgnoreCase;
        /// <summary>
        /// Only select variables instances which have on of the variable scope ids.
        /// </summary>
        [JsonProperty("variableScopeIdIn")]
        public List<string> VariableScopeId = [];
    }

    public enum VariableInstanceSorting
    {
        VariableName,
        VariableType,
        ActivityInstanceId,
        TenantId
    }
}

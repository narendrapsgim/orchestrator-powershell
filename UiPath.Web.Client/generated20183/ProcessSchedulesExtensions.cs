// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace UiPath.Web.Client20183
{
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for ProcessSchedules.
    /// </summary>
    public static partial class ProcessSchedulesExtensions
    {
            /// <summary>
            /// Gets the process schedules.
            /// </summary>
            /// <remarks>
            /// Required permissions: Schedules.View.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='expand'>
            /// Expands related entities inline.
            /// </param>
            /// <param name='filter'>
            /// Filters the results, based on a Boolean condition.
            /// </param>
            /// <param name='select'>
            /// Selects which properties to include in the response.
            /// </param>
            /// <param name='orderby'>
            /// Sorts the results.
            /// </param>
            /// <param name='top'>
            /// Returns only the first n results.
            /// </param>
            /// <param name='skip'>
            /// Skips the first n results.
            /// </param>
            /// <param name='count'>
            /// Includes a count of the matching results in the response.
            /// </param>
            public static ODataResponseListProcessScheduleDto GetProcessSchedules(this IProcessSchedules operations, string expand = default(string), string filter = default(string), string select = default(string), string orderby = default(string), int? top = default(int?), int? skip = default(int?), bool? count = default(bool?))
            {
                return operations.GetProcessSchedulesAsync(expand, filter, select, orderby, top, skip, count).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets the process schedules.
            /// </summary>
            /// <remarks>
            /// Required permissions: Schedules.View.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='expand'>
            /// Expands related entities inline.
            /// </param>
            /// <param name='filter'>
            /// Filters the results, based on a Boolean condition.
            /// </param>
            /// <param name='select'>
            /// Selects which properties to include in the response.
            /// </param>
            /// <param name='orderby'>
            /// Sorts the results.
            /// </param>
            /// <param name='top'>
            /// Returns only the first n results.
            /// </param>
            /// <param name='skip'>
            /// Skips the first n results.
            /// </param>
            /// <param name='count'>
            /// Includes a count of the matching results in the response.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<ODataResponseListProcessScheduleDto> GetProcessSchedulesAsync(this IProcessSchedules operations, string expand = default(string), string filter = default(string), string select = default(string), string orderby = default(string), int? top = default(int?), int? skip = default(int?), bool? count = default(bool?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                using (var _result = await operations.GetProcessSchedulesWithHttpMessagesAsync(expand, filter, select, orderby, top, skip, count, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Creates a new process schedule.
            /// </summary>
            /// <remarks>
            /// Required permissions: Schedules.Create.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='processScheduleDto'>
            /// The entity to post
            /// </param>
            public static ProcessScheduleDto Post(this IProcessSchedules operations, ProcessScheduleDto processScheduleDto)
            {
                return operations.PostAsync(processScheduleDto).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Creates a new process schedule.
            /// </summary>
            /// <remarks>
            /// Required permissions: Schedules.Create.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='processScheduleDto'>
            /// The entity to post
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<ProcessScheduleDto> PostAsync(this IProcessSchedules operations, ProcessScheduleDto processScheduleDto, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                using (var _result = await operations.PostWithHttpMessagesAsync(processScheduleDto, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets a single process schedule based on its key.
            /// </summary>
            /// <remarks>
            /// Required permissions: Schedules.View.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='id'>
            /// key: Id
            /// </param>
            /// <param name='expand'>
            /// Expands related entities inline.
            /// </param>
            /// <param name='select'>
            /// Selects which properties to include in the response.
            /// </param>
            public static ProcessScheduleDto GetById(this IProcessSchedules operations, long id, string expand = default(string), string select = default(string))
            {
                return operations.GetByIdAsync(id, expand, select).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets a single process schedule based on its key.
            /// </summary>
            /// <remarks>
            /// Required permissions: Schedules.View.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='id'>
            /// key: Id
            /// </param>
            /// <param name='expand'>
            /// Expands related entities inline.
            /// </param>
            /// <param name='select'>
            /// Selects which properties to include in the response.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<ProcessScheduleDto> GetByIdAsync(this IProcessSchedules operations, long id, string expand = default(string), string select = default(string), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                using (var _result = await operations.GetByIdWithHttpMessagesAsync(id, expand, select, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Edits a process schedule.
            /// </summary>
            /// <remarks>
            /// Required permissions: Schedules.Edit.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='id'>
            /// key: Id
            /// </param>
            /// <param name='processScheduleDto'>
            /// The entity to put
            /// </param>
            public static ProcessScheduleDto PutById(this IProcessSchedules operations, long id, ProcessScheduleDto processScheduleDto)
            {
                return operations.PutByIdAsync(id, processScheduleDto).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Edits a process schedule.
            /// </summary>
            /// <remarks>
            /// Required permissions: Schedules.Edit.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='id'>
            /// key: Id
            /// </param>
            /// <param name='processScheduleDto'>
            /// The entity to put
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<ProcessScheduleDto> PutByIdAsync(this IProcessSchedules operations, long id, ProcessScheduleDto processScheduleDto, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                using (var _result = await operations.PutByIdWithHttpMessagesAsync(id, processScheduleDto, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Deletes a process schedule.
            /// </summary>
            /// <remarks>
            /// Required permissions: Schedules.Delete.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='id'>
            /// key: Id
            /// </param>
            /// <param name='ifMatch'>
            /// If-Match header
            /// </param>
            public static void DeleteById(this IProcessSchedules operations, long id, string ifMatch = default(string))
            {
                operations.DeleteByIdAsync(id, ifMatch).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Deletes a process schedule.
            /// </summary>
            /// <remarks>
            /// Required permissions: Schedules.Delete.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='id'>
            /// key: Id
            /// </param>
            /// <param name='ifMatch'>
            /// If-Match header
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task DeleteByIdAsync(this IProcessSchedules operations, long id, string ifMatch = default(string), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                (await operations.DeleteByIdWithHttpMessagesAsync(id, ifMatch, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Enables/disables a group of schedules.
            /// </summary>
            /// <remarks>
            /// Required permissions: Schedules.Edit.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='setEnabledParameters'>
            /// &lt;para /&gt;Enabled - If true the schedules will be enabled, if false the
            /// schedules will be disabled.
            /// &lt;para /&gt;ScheduleIds - The collection of ids of the affected
            /// schedules.
            /// </param>
            public static ODataResponseBoolean SetEnabled(this IProcessSchedules operations, SetEnabledParameters setEnabledParameters)
            {
                return operations.SetEnabledAsync(setEnabledParameters).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Enables/disables a group of schedules.
            /// </summary>
            /// <remarks>
            /// Required permissions: Schedules.Edit.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='setEnabledParameters'>
            /// &lt;para /&gt;Enabled - If true the schedules will be enabled, if false the
            /// schedules will be disabled.
            /// &lt;para /&gt;ScheduleIds - The collection of ids of the affected
            /// schedules.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<ODataResponseBoolean> SetEnabledAsync(this IProcessSchedules operations, SetEnabledParameters setEnabledParameters, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                using (var _result = await operations.SetEnabledWithHttpMessagesAsync(setEnabledParameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Returns a collection of all the ids of the robots associated to an schedule
            /// based on schedule Id.
            /// </summary>
            /// <remarks>
            /// Required permissions: Schedules.View.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='key'>
            /// The Id of the schedule for which the robot ids are fetched.
            /// </param>
            public static ODataResponseListInt64 GetRobotIdsForScheduleByKey(this IProcessSchedules operations, long key)
            {
                return operations.GetRobotIdsForScheduleByKeyAsync(key).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Returns a collection of all the ids of the robots associated to an schedule
            /// based on schedule Id.
            /// </summary>
            /// <remarks>
            /// Required permissions: Schedules.View.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='key'>
            /// The Id of the schedule for which the robot ids are fetched.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<ODataResponseListInt64> GetRobotIdsForScheduleByKeyAsync(this IProcessSchedules operations, long key, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                using (var _result = await operations.GetRobotIdsForScheduleByKeyWithHttpMessagesAsync(key, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}

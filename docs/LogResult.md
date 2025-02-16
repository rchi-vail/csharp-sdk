# freeclimb.Model.LogResult

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Timestamp** | **int?** | Time that the log was generated. The time is represented as microseconds since the Unix Epoch. | [optional] 
**Level** | **string** | Level of the log. Possible values are info, warning, and error. | [optional] 
**RequestId** | **string** | ID of the request associated with the log. The requestId is propagated across all logs generated by FreeClimb when processing a request. | [optional] 
**AccountId** | **string** | ID of the account that this log was generated under. | [optional] 
**CallId** | **string** | ID of the Call associated with the log. Can be set to null if the log was generated without regard to a specific Call. | [optional] 
**Message** | **string** | A simple string describing the event being logged. | [optional] 
**Metadata** | **Object** | JSON document containing metadata about the event. Some log messages may include request and response header content in this field. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


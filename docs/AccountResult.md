# freeclimb.Model.AccountResult

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Uri** | **string** | The URI for this resource, relative to /apiserver. | [optional] 
**DateCreated** | **string** | The date that this resource was created (GMT) in RFC 1123 format (e.g., Mon, 15 Jun 2009 20:45:30 GMT). | [optional] 
**DateUpdated** | **string** | The date that this resource was last updated (GMT) in RFC 1123 format (e.g., Mon, 15 Jun 2009 20:45:30 GMT). | [optional] 
**Revision** | **int** | Revision count for the resource. This count is set to 1 on creation and is incremented every time it is updated. | [optional] 
**AccountId** | **string** | String that uniquely identifies this account resource. | [optional] 
**ApiKey** | **string** | The API key assigned to this account. This key must be kept a secret by the customer. | [optional] 
**Alias** | **string** | A description for this account. | [optional] 
**Label** | **string** | A string that identifies a category or group to which the account belongs. | [optional] 
**Type** | **string** | The type of this account. It is one of: trial or full. | [optional] 
**Status** | **string** | The status of this account. It is one of: active, suspended, or closed. | [optional] 
**SubresourceUris** | **Object** | The list of subresources for this account. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


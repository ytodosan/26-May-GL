define("UsrYachts_ListPage", /**SCHEMA_DEPS*/[]/**SCHEMA_DEPS*/, function/**SCHEMA_ARGS*/()/**SCHEMA_ARGS*/ {
	return {
		viewConfigDiff: /**SCHEMA_VIEW_CONFIG_DIFF*/[
			{
				"operation": "merge",
				"name": "MenuItem_ImportFromExcel",
				"values": {
					"clicked": {
						"request": "crt.ImportDataRequest",
						"params": {
							"entitySchemaName": "UsrYachts"
						}
					}
				}
			},
			{
				"operation": "merge",
				"name": "FolderTree",
				"values": {
					"rootSchemaName": "UsrYachts"
				}
			},
			{
				"operation": "merge",
				"name": "DataTable",
				"values": {
					"columns": [
						{
							"id": "f252f581-0ccf-44ac-b7c9-c00df2ad9919",
							"code": "PDS_UsrName",
							"caption": "#ResourceString(PDS_UsrName)#",
							"dataValueType": 1,
							"width": 194,
							"sticky": true
						},
						{
							"id": "47870970-a0f6-55c0-a8c5-1a9df66c337b",
							"code": "PDS_UsrNumber",
							"caption": "#ResourceString(PDS_UsrNumber)#",
							"dataValueType": 27
						},
						{
							"id": "b7660cce-3b42-c003-486d-db9b365ebb0f",
							"code": "PDS_UsrDriveType",
							"caption": "#ResourceString(PDS_UsrDriveType)#",
							"dataValueType": 10
						},
						{
							"id": "8106b20d-b194-caab-57c4-62dd7b84decd",
							"code": "PDS_UsrStatus",
							"caption": "#ResourceString(PDS_UsrStatus)#",
							"dataValueType": 10
						},
						{
							"id": "2e85966c-e028-67fe-7d70-5a9fac19aa0b",
							"code": "PDS_UsrCaptain",
							"caption": "#ResourceString(PDS_UsrCaptain)#",
							"dataValueType": 10
						},
						{
							"id": "e09d2d79-8263-f7de-efc4-5cbaaeb13d71",
							"code": "PDS_UsrYachtRentalUsrParentYacht_Id_lkfedxz",
							"caption": "#ResourceString(PDS_UsrYachtRentalUsrParentYacht_Id_lkfedxz)#",
							"dataValueType": 4
						}
					],
					"features": {
						"rows": {
							"selection": {
								"enable": true,
								"multiple": true
							}
						},
						"columns": {
							"sorting": true,
							"dragAndDrop": true,
							"resizing": true,
							"adding": false
						},
						"editable": {
							"enable": false,
							"floatingEditPanel": false,
							"itemsCreation": false
						},
						"header": {
							"visible": true
						}
					}
				}
			},
			{
				"operation": "merge",
				"name": "Dashboards",
				"values": {
					"_designOptions": {
						"entitySchemaName": "UsrYachts",
						"dependencies": [
							{
								"attributePath": "Id",
								"relationPath": "PDS.Id"
							}
						],
						"filters": []
					}
				}
			}
		]/**SCHEMA_VIEW_CONFIG_DIFF*/,
		viewModelConfigDiff: /**SCHEMA_VIEW_MODEL_CONFIG_DIFF*/[
			{
				"operation": "merge",
				"path": [
					"attributes",
					"Items",
					"viewModelConfig",
					"attributes"
				],
				"values": {
					"PDS_UsrName": {
						"modelConfig": {
							"path": "PDS.UsrName"
						}
					},
					"PDS_UsrNumber": {
						"modelConfig": {
							"path": "PDS.UsrNumber"
						}
					},
					"PDS_UsrDriveType": {
						"modelConfig": {
							"path": "PDS.UsrDriveType"
						}
					},
					"PDS_UsrStatus": {
						"modelConfig": {
							"path": "PDS.UsrStatus"
						}
					},
					"PDS_UsrCaptain": {
						"modelConfig": {
							"path": "PDS.UsrCaptain"
						}
					},
					"PDS_UsrYachtRentalUsrParentYacht_Id_lkfedxz": {
						"modelConfig": {
							"path": "PDS.UsrYachtRentalUsrParentYacht_Id_lkfedxz"
						}
					}
				}
			},
			{
				"operation": "merge",
				"path": [
					"attributes",
					"Items",
					"modelConfig",
					"pagingConfig"
				],
				"values": {
					"rowsLimit": null
				}
			},
			{
				"operation": "merge",
				"path": [
					"attributes",
					"Items",
					"modelConfig",
					"sortingConfig"
				],
				"values": {
					"default": [
						{
							"direction": "asc",
							"columnName": "UsrNumber"
						}
					]
				}
			}
		]/**SCHEMA_VIEW_MODEL_CONFIG_DIFF*/,
		modelConfigDiff: /**SCHEMA_MODEL_CONFIG_DIFF*/[
			{
				"operation": "merge",
				"path": [
					"dataSources",
					"PDS",
					"config"
				],
				"values": {
					"entitySchemaName": "UsrYachts",
					"attributes": {
						"UsrName": {
							"path": "UsrName"
						},
						"UsrNumber": {
							"path": "UsrNumber"
						},
						"UsrDriveType": {
							"path": "UsrDriveType"
						},
						"UsrStatus": {
							"path": "UsrStatus"
						},
						"UsrCaptain": {
							"path": "UsrCaptain"
						},
						"UsrYachtRentalUsrParentYacht_Id_lkfedxz": {
							"type": "Aggregation",
							"path": "[UsrYachtRental:UsrParentYacht].Id",
							"aggregationConfig": {
								"aggregationFunction": "Count"
							}
						}
					}
				}
			}
		]/**SCHEMA_MODEL_CONFIG_DIFF*/,
		handlers: /**SCHEMA_HANDLERS*/[]/**SCHEMA_HANDLERS*/,
		converters: /**SCHEMA_CONVERTERS*/{}/**SCHEMA_CONVERTERS*/,
		validators: /**SCHEMA_VALIDATORS*/{}/**SCHEMA_VALIDATORS*/
	};
});
/****************************** Module Header ******************************\
* Module Name:  ServiceTriggerStart.h
* Project:      CppWin7TriggerStartService
* Copyright (c) Microsoft Corporation.
* 
* The file declares functions to set and get the configuration of service 
* trigger start.
* 
* * SupportServiceTriggerStart:
*   Check whether the current system supports service trigger start. Service 
*   trigger events are not supported until Windows Server 2008 R2 and Windows 
*   7. Wndows Server 2008 R2 and Windows 7 have major version 6 and minor 
*   version 1.
*   
* * GetServiceTriggerInfo
*   Get the trigger-start configuration of a service.
* 
* * SetServiceTriggerStartOnUSBArrival
*   Set the service to trigger-start when a generic USB disk is available.
* 
* * SetServiceTriggerStartOnIPAddressArrival
*   Set the service to trigger-start when the first IP address on the TCP/IP 
*   networking stack becomes available, and trigger-stop when the last IP 
*   address on the TCP/IP networking stack becomes unavailable.
* 
* Services and background processes have tremendous influence on the overall 
* performance of the system. If we could just cut down on the total number of 
* services, we would reduce the total power consumption and increase the 
* overall stability of the system. The Windows 7 Service Control Manager has 
* been extended so that a service can be automatically started and stopped 
* when a specific system event, or trigger, occurs on the system. The new 
* mechanism is called Service Trigger Event. A service can register to be 
* started or stopped when a trigger event occurs. This eliminates the need 
* for services to start when the system starts, or for services to poll or 
* actively wait for an event; a service can start when it is needed, instead 
* of starting automatically whether or not there is work to do. Examples of 
* predefined trigger events include arrival of a device of a specified device 
* interface class or availability of a particular firewall port. A service 
* can also register for a custom trigger event generated by an Event Tracing 
* for Windows (ETW) provider.
* 
* This source is subject to the Microsoft Public License.
* See http://www.microsoft.com/opensource/licenses.mspx#Ms-PL.
* All other rights reserved.
* 
* THIS CODE AND INFORMATION IS PROVIDED "AS IS" WITHOUT WARRANTY OF ANY KIND, 
* EITHER EXPRESSED OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE IMPLIED 
* WARRANTIES OF MERCHANTABILITY AND/OR FITNESS FOR A PARTICULAR PURPOSE.
\***************************************************************************/

#pragma once


//
//  FUNCTION: SupportServiceTriggerStart
//
//  PURPOSE: Check whether the current system supports service trigger start
//
//  PARAMETERS:
//    none
//
//  RETURN VALUE:
//    TRUE if the current system supports service trigger start
//    FALSE if the current system does not support service trigger start
//
//  COMMENTS:
//    Service trigger events are not supported until Windows Server 2008 
//    R2 and Windows 7. Wndows Server 2008 R2 and Windows 7 have major 
//    version 6 and minor version 1.
//
BOOL SupportServiceTriggerStart();


//
//  FUNCTION: GetServiceTriggerInfo
//
//  PURPOSE: Get the trigger-start configuration of a service
//
//  PARAMETERS:
//    hService - A handle to the service. This handle is returned by the 
//      OpenService or CreateService function and must have the 
//      SERVICE_QUERY_CONFIG access right. 
//    lpfIsTriggerStart - Output a pointer to a variable that indicates 
//      whether the service is configured to trigger start
//
//  RETURN VALUE:
//    TRUE if the function succeeds
//    FALSE if the function fails. To get extended error information, call 
//      GetLastError.
//
//  COMMENTS:
//    none
//
BOOL GetServiceTriggerInfo(SC_HANDLE hService, LPBOOL lpfIsTriggerStart);


//
//  FUNCTION: SetServiceTriggerStartOnUSBArrival
//
//  PURPOSE: Set the service to trigger-start when a generic USB disk becomes 
//    available. 
//
//  PARAMETERS:
//    hService - A handle to the service. This handle is returned by the 
//      OpenService or CreateService function and must have the 
//      SERVICE_CHANGE_CONFIG access right.
//
//  RETURN VALUE:
//    TRUE if the function succeeds
//    FALSE if the function fails. To get extended error information, call 
//      GetLastError.
//
//  COMMENTS:
//    none
//
BOOL SetServiceTriggerStartOnUSBArrival(SC_HANDLE hService);


//
//  FUNCTION: SetServiceTriggerStartOnIPAddressArrival
//
//  PURPOSE: Set the service to trigger-start when the first IP address on 
//    the TCP/IP networking stack becomes available, and trigger-stop when 
//    the last IP address on the TCP/IP networking stack becomes unavailable.
//
//  PARAMETERS:
//    hService - A handle to the service. This handle is returned by the 
//      OpenService or CreateService function and must have the 
//      SERVICE_CHANGE_CONFIG access right.
//
//  RETURN VALUE:
//    TRUE if the function succeeds
//    FALSE if the function fails. To get extended error information, call 
//      GetLastError.
//
//  COMMENTS:
//    none
//
BOOL SetServiceTriggerStartOnIPAddressArrival(SC_HANDLE hService);


//
//  FUNCTION: SetServiceTriggerStartOnFirewallPortEvent
//
//  PURPOSE: Set the service to trigger-start when a firewall port (UDP 5001 
//    in this example) is opened, and trigger-stop when the a firewall port 
//    (UDP 5001 in this example) is closed. 
//
//  PARAMETERS:
//    hService - A handle to the service. This handle is returned by the 
//      OpenService or CreateService function and must have the 
//      SERVICE_CHANGE_CONFIG access right.
//
//  RETURN VALUE:
//    TRUE if the function succeeds
//    FALSE if the function fails. To get extended error information, call 
//      GetLastError.
//
//  COMMENTS:
//    none
//
BOOL SetServiceTriggerStartOnFirewallPortEvent(SC_HANDLE hService);
//
//  PilgrimInterface.m
//  PilgrimUnitySDK
//
//  Copyright © 2018 Foursquare. All rights reserved.
//

#import "PilgrimTypes.h"
#import "PilgrimClient.h"

PilgrimClientRef CreateClient(PilgrimClientHandleRef clientHandlePtr) {
    PilgrimClient *client = [[PilgrimClient alloc] initWithClientHandle:clientHandlePtr];
    return CFBridgingRetain(client);
}

void SetCallbacks(PilgrimClientRef clientPtr,
                  PilgrimLocationPermissionsCallback locationPermissionsCallback,
                  PilgrimGetCurrentLocationCallback getCurrentLocationCallback) {
    PilgrimClient *client = (__bridge PilgrimClient *)(clientPtr);
    client.locationPermissionsCallback = locationPermissionsCallback;
    client.getCurrentLocationCallback = getCurrentLocationCallback;
}

void SetUserInfo(PilgrimClientRef clientPtr, const char *userInfoJson) {
    PilgrimClient *client = (__bridge PilgrimClient *)(clientPtr);
    [client setUserInfo:userInfoJson];
}

void RequestLocationPermissions(PilgrimClientRef clientPtr) {
    PilgrimClient *client = (__bridge PilgrimClient *)(clientPtr);
    [client requestLocationPermissions];
}

void Start(PilgrimClientRef clientPtr) {
    PilgrimClient *client = (__bridge PilgrimClient *)(clientPtr);
    [client start];
}

void Stop(PilgrimClientRef clientPtr) {
    PilgrimClient *client = (__bridge PilgrimClient *)(clientPtr);
    [client stop];
}

void ClearAllData(PilgrimClientRef clientPtr) {
    PilgrimClient *client = (__bridge PilgrimClient *)(clientPtr);
    [client clearAllData];
}

void GetCurrentLocation(PilgrimClientRef clientPtr) {
    PilgrimClient *client = (__bridge PilgrimClient *)(clientPtr);
    [client getCurrentLocation];
}

void Destroy(PilgrimClientRef clientPtr) {
    PilgrimClient *client = (__bridge PilgrimClient *)(clientPtr);
    CFRelease((__bridge CFTypeRef)(client));
}
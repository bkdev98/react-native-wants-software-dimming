
#import "RNWantsSoftwareDimming.h"

@implementation RNWantsSoftwareDimming

- (dispatch_queue_t)methodQueue
{
    return dispatch_get_main_queue();
}

RCT_EXPORT_MODULE();

RCT_EXPORT_METHOD(enable)
{
    [UIScreen mainScreen].wantsSoftwareDimming = YES;
    [UIScreen mainScreen].brightness = 0;
}

@end


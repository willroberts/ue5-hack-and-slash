// © 2023 Will Roberts

#pragma once

#include "CoreMinimal.h"
#include "Kismet/BlueprintFunctionLibrary.h"
#include "RotationInterpolator.generated.h"

/*
 * URotationInterpolator provides a Blueprint-accessible way to interpolate the Player's rotation.
 */
UCLASS()
class HACKANDSLASH_UE5_API URotationInterpolator : public UBlueprintFunctionLibrary
{
	GENERATED_BODY()

public:
	UFUNCTION(BlueprintCallable)
	static bool InterpolatePlayerRotation(float InterpSpeed = 5.0);
};

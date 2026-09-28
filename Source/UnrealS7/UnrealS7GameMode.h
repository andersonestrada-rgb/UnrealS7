// Copyright Epic Games, Inc. All Rights Reserved.

#pragma once

#include "CoreMinimal.h"
#include "GameFramework/GameModeBase.h"
#include "UnrealS7GameMode.generated.h"

/**
 *  Simple GameMode for a third person game
 */
UCLASS(abstract)
class AUnrealS7GameMode : public AGameModeBase
{
	GENERATED_BODY()

public:
	
	/** Constructor */
	AUnrealS7GameMode();
};




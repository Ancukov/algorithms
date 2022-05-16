using System;

namespace identicalElements
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arr1 = {
                "ValidationError",
                "ServerError",
                "TaskNotFound",
                "InvalidWarehouse",
                "TaskHasAnotherType",
                "ForbiddenInspectingDcTaskType",
                "PalletNotFound",
                "PalletIsEmpty",
                "PalletAlreadyAttachedToUser",
                "PickingPallet",
                "BoxNotFound",
                "BoxIsEmpty",
                "DifferentStatusesOfContentInTheBox",
                "PalletIsNotEmpty",
                "BoxNotOnPallet",
                "InvalidTaskStatus",
                "TaskWithoutPallets",
                "PalletIsNotAdded",
                "PalletAlreadyAddedToTask",
                "PalletAttachedToAnotherTask",
                "BoxingIsEmpty",
                "BoxingNotFound",
                "TaskAssignOnAnotherUser",
                "TaskNotAssignedToUser",
                "InvalidPurpose",
                "TaskHasNotClosedPallets",
                "TaskHasNotClosedBoxes",
                "BoundRackNotFound",
                "CellsInRackNotFound",
                "PalletAlreadyClosed",
                "PalletAlreadyMixed",
                "BoxContentIsMixed",
                "BoxIsNotToInspect",
                "BoxAlreadyClosed",
                "TaskAlreadyHasInProgressBox",
                "TaskAlreadyHasInProgressPallet",
                "PalletNotInProgress",
                "BoxHasNotNonePurpose",
                "BoxIsNotEmpty",
                "PalletHasIncorrectType",
                "PalletAlreadyInProcess",
                "ItemsMoving",
                "BoxHasIncorrectState",
                "BoxHasIncorrectPurpose",
                "BoxIsNotInTask",
                "PalletHasIncorrectPurpose",
                "BoxingIsNotEmpty",
                "SupplyNotFound",
                "ExpirationDoesntMatch",
                "MissingExpirationDate",
                "TooBigExpirationDate",
                "LowExpirationPeriod",
                "ItemIsAlreadyInBoxException",
                "ItemNotFoundException",
                "TaskHasNotBoxInProgress",
                "TagRestriction",
                "PalletHasOpenBoxes",
                "NoSurplus",
                "BoxHasSurplus",
                "IncorrectDestinationPallet",
                "NotEnoughVirtualInstances",
                "SurplusPallet",
                "ExternalBoxingService",
                "ExternalEmployeeService",
                "ExternalExpirationValidationService",
                "ExternalItemService",
                "ExternalSettingsService",
                "ExternalStorageService",
                "ExternalSupplyService",
                "ExternalTagRestrictionService",
                "ExternalTaskService",
                "ExternalTopologyService",
                "ExternalVirtualInstanceService" };

        string[] arr2 = {
                "ValidationError",
                "ServerError",
                "TaskNotFound",
                "InvalidWarehouse",
                "TaskHasAnotherType",
                "ForbiddenInspectingDcTaskType",
                "PalletNotFound",
                "PalletIsEmpty",
                "PalletAlreadyAttachedToUser",
                "PickingPallet",
                "BoxNotFound",
                "BoxIsEmpty",
                "DifferentStatusesOfContentInTheBox",
                "PalletIsNotEmpty",
                "BoxNotOnPallet",
                "InvalidTaskStatus",
                "TaskWithoutPallets",
                "PalletIsNotAdded",
                "PalletAlreadyAddedToTask",
                "PalletAttachedToAnotherTask",
                "BoxingIsEmpty",
                "BoxingNotFound",
                "TaskAssignOnAnotherUser",
                "TaskNotAssignedToUser",
                "InvalidPurpose",
                "TaskHasNotClosedPallets",
                "TaskHasNotClosedBoxes",
                "BoundRackNotFound",
                "CellsInRackNotFound",
                "PalletAlreadyClosed",
                "PalletAlreadyMixed",
                "BoxContentIsMixed",
                "BoxIsNotToInspect",
                "BoxAlreadyClosed",
                "TaskAlreadyHasInProgressBox",
                "TaskAlreadyHasInProgressPallet",
                "PalletNotInProgress",
                "BoxHasNotNonePurpose",
                "BoxIsNotEmpty",
                "PalletHasIncorrectType",
                "PalletAlreadyInProcess",
                "ItemsMoving",
                "BoxHasIncorrectState",
                "BoxHasIncorrectPurpose",
                "BoxIsNotInTask",
                "PalletHasIncorrectPurpose",
                "BoxingIsNotEmpty",
                "SupplyNotFound",
                "ExpirationDoesntMatch",
                "MissingExpirationDate",
                "TooBigExpirationDate",
                "LowExpirationPeriod",
                "ItemIsAlreadyInBoxException",
                "ItemNotFoundException",
                "TaskHasNotBoxInProgress",
                "TagRestriction",
                "PalletHasOpenBoxes",
                "NoSurplus",
                "BoxHasSurplus",
                "IncorrectDestinationPallet",
                "NotEnoughVirtualInstances",
                "SurplusPallet" };
        Elements elements = new Elements();
            foreach(var str in arr1)
            {
                elements.Element(arr2, str);
            }
        }
    }
    class Elements
    {
        public void Element(string[] aray2, string elemt)
        {
            var result = 0;
            for(int i = 0; i < aray2.Length; i++)
            {
                if(aray2[i] == elemt)
                {
                    result = 1;
                    break;
                }
            }
            if (result == 0)
            {
                Console.WriteLine(elemt);
            }
        }
    }
}

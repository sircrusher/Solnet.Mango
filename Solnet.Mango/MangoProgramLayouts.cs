namespace Solnet.Mango
{
    /// <summary>
    /// Layouts associated with encoding and decoding of <see cref="MangoProgram"/> instructions.
    /// </summary>
    internal static class MangoProgramLayouts
    {
        /// <summary>
        /// The offset at which to write the method value.
        /// </summary>
        internal const int MethodOffset = 0;

        /// <summary>
        /// The offset at which to write the quantity amount for the <see cref="MangoProgramInstructions.Values.Deposit"/> instruction.
        /// </summary>
        internal const int DepositQuantityOffset = 4;

        /// <summary>
        /// The offset at which to write the quantity amount for the <see cref="MangoProgramInstructions.Values.Withdraw"/> instruction.
        /// </summary>
        internal const int WithdrawQuantityOffset = 4;

        /// <summary>
        /// The offset at which to write the allow borrow flag for the <see cref="MangoProgramInstructions.Values.Withdraw"/> instruction.
        /// </summary>
        internal const int WithdrawAllowBorrowOffset = 12;

        /// <summary>
        /// The offset at which to write the mango account info for the <see cref="MangoProgramInstructions.Values.AddMangoAccountInfo"/> instruction.
        /// </summary>
        internal const int MangoAccountInfoOffset = 4;

        /// <summary>
        /// The offset at which to write the order index value for the <see cref="MangoProgramInstructions.Values.RemoveAdvancedOrder"/> and <see cref="MangoProgramInstructions.Values.ExecutePerpTriggerOrder"/> instructions.
        /// </summary>
        internal const int OrderIndexOffset = 4;

        /// <summary>
        /// The offset at which to write the account number value for the <see cref="MangoProgramInstructions.Values.CreateMangoAccount"/> instruction.
        /// </summary>
        internal const int AccountNumOffset = 4;

        /// <summary>
        /// Represents the layout of the <see cref="MangoProgramInstructions.Values.PlacePerpOrder"/> method encoded data structure.
        /// </summary>
        internal static class PlacePerpOrder
        {
            /// <summary>
            /// The offset at which to write the price value.
            /// </summary>
            internal const int PriceOffset = 4;

            /// <summary>
            /// The offset at which to write the quantity value.
            /// </summary>
            internal const int QuantityOffset = 12;

            /// <summary>
            /// The offset at which to write the client order id value.
            /// </summary>
            internal const int ClientOrderIdOffset = 20;

            /// <summary>
            /// The offset at which to write the side value.
            /// </summary>
            internal const int SideOffset = 28;

            /// <summary>
            /// The offset at which to write the order type value.
            /// </summary>
            internal const int OrderTypeOffset = 29;

            /// <summary>
            /// The offset at which to write the reduce only flag value.
            /// </summary>
            internal const int ReduceOnlyOffset = 30;
        }

        /// <summary>
        /// Represents the layout of the <see cref="MangoProgramInstructions.Values.PlacePerpOrder2"/> method encoded data structure.
        /// </summary>
        internal static class PlacePerpOrder2
        {
            /// <summary>
            /// The offset at which to write the price value.
            /// </summary>
            internal const int PriceOffset = 4;

            /// <summary>
            /// The offset at which to write the max base quantity value.
            /// </summary>
            internal const int MaxBaseQuantityOffset = 12;

            /// <summary>
            /// The offset at which to write the max quote quantity value.
            /// </summary>
            internal const int MaxQuoteQuantityOffset = 20;

            /// <summary>
            /// The offset at which to write the client order id value.
            /// </summary>
            internal const int ClientOrderIdOffset = 28;

            /// <summary>
            /// The offset at which to write the expiry timestamp value.
            /// </summary>
            internal const int ExpiryTimestampOffset = 36;

            /// <summary>
            /// The offset at which to write the side value.
            /// </summary>
            internal const int SideOffset = 44;

            /// <summary>
            /// The offset at which to write the order type value.
            /// </summary>
            internal const int OrderTypeOffset = 45;

            /// <summary>
            /// The offset at which to write the reduce only flag value.
            /// </summary>
            internal const int ReduceOnlyOffset = 46;

            /// <summary>
            /// The offset at which to write the limit value.
            /// </summary>
            internal const int LimitOffset = 47;
        }

        /// <summary>
        /// Represents the layout of the <see cref="MangoProgramInstructions.Values.CancelPerpOrderByClientId"/> method encoded data structure.
        /// </summary>
        internal static class CancelPerpOrderByClientId
        {
            /// <summary>
            /// The offset at which to write the client order id value.
            /// </summary>
            internal const int ClientOrderIdOffset = 4;

            /// <summary>
            /// The offset at which to write the invalid id ok? value.
            /// </summary>
            internal const int InvalidIdOkOffset = 12;
        }

        /// <summary>
        /// Represents the layout of the <see cref="MangoProgramInstructions.Values.CancelPerpOrder"/> method encoded data structure.
        /// </summary>
        internal static class CancelPerpOrder
        {
            /// <summary>
            /// The offset at which to write the client order id value.
            /// </summary>
            internal const int OrderIdOffset = 4;

            /// <summary>
            /// The offset at which to write the invalid id ok? value.
            /// </summary>
            internal const int InvalidIdOkOffset = 20;
        }

        /// <summary>
        /// Represents the layout of the <see cref="MangoProgramInstructions.Values.PlaceSpotOrder"/> method encoded data structure.
        /// </summary>
        internal static class PlaceSpotOrder
        {
            /// <summary>
            /// The offset at which to write the order side value.
            /// </summary>
            internal const int SideOffset = 4;

            /// <summary>
            /// The offset at which to write the limit price value.
            /// </summary>
            internal const int PriceOffset = 8;

            /// <summary>
            /// The offset at which to write the max base quantity value.
            /// </summary>
            internal const int MaxBaseQuantityOffset = 16;

            /// <summary>
            /// The offset at which to write the max quote quantity value.
            /// </summary>
            internal const int MaxQuoteQuantity = 24;

            /// <summary>
            /// The offset at which to write the self trade behavior value.
            /// </summary>
            internal const int SelfTradeBehaviorOffset = 32;

            /// <summary>
            /// The offset at which to write the order type value.
            /// </summary>
            internal const int OrderTypeOffset = 36;

            /// <summary>
            /// The offset at which to write the client id value.
            /// </summary>
            internal const int ClientIdOffset = 40;

            /// <summary>
            /// The offset at which to write the limit value.
            /// </summary>
            internal const int LimitOffset = 48;
        }

        /// <summary>
        /// Represents the layout of the <see cref="MangoProgramInstructions.Values.CancelSpotOrder"/> method encoded data structure.
        /// </summary>
        internal static class CancelSpotOrder
        {
            /// <summary>
            /// The offset at which to write the order side value.
            /// </summary>
            internal const int SideOffset = 4;

            /// <summary>
            /// The offset at which to write the order id value.
            /// </summary>
            internal const int OrderIdOffset = 8;
        }

        /// <summary>
        /// Represents the layout of the <see cref="MangoProgramInstructions.Values.AddPerpTriggerOrder"/> method encoded data structure.
        /// </summary>
        internal static class AddPerpTriggerOrder
        {
            /// <summary>
            /// The offset at which to write the order type value.
            /// </summary>
            internal const int OrderTypeOffset = 4;

            /// <summary>
            /// The offset at which to write the order side value.
            /// </summary>
            internal const int SideOffset = 5;

            /// <summary>
            /// The offset at which to write the trigger condition value.
            /// </summary>
            internal const int TriggerConditionOffset = 6;

            /// <summary>
            /// The offset at which to write the reduce only flag value.
            /// </summary>
            internal const int ReduceOnlyOffset = 7;

            /// <summary>
            /// The offset at which to write the client order id value.
            /// </summary>
            internal const int ClientOrderIdOffset = 8;

            /// <summary>
            /// The offset at which to write the limit price value.
            /// </summary>
            internal const int PriceOffset = 16;

            /// <summary>
            /// The offset at which to write the quantity value.
            /// </summary>
            internal const int QuantityOffset = 24;

            /// <summary>
            /// The offset at which to write the trigger price value.
            /// </summary>
            internal const int TriggerPriceOffset = 32;
        }
        
        /// <summary>
        /// Represents the layout of the <see cref="MangoProgramInstructions.Values.CancelPerpOrdersSide"/> method encoded data structure.
        /// </summary>
        internal static class CancelPerpOrdersSide
        {
            /// <summary>
            /// The offset at which to write the order side value.
            /// </summary>
            internal const int SideOffset = 4;

            /// <summary>
            /// The offset at which to write the limit value. 
            /// </summary>
            internal const int LimitOffset = 5;
        }
    }
}
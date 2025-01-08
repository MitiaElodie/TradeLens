import { TRADE_TYPES } from "@/constants.js";

export function getTradePrefix(type: string): string {
   return TRADE_TYPES[type].prefix;
}

export function getTradePrefixedId(id: number, type: string): string {
   return `${getTradePrefix(type)}-${id}`;
}

export function getEmptyTrade(): object {
   return {
      type: '',
      pair: '',
      result: '',
      weeklyLastCandleClose: false,
      weeklySupplyAndDemand: false,
      weeklyMarketStructure: false,
      weeklyFibonacci: false,
      dailyPattern: '',
      h4Pattern: '',
      weeklyScreenshot: '',
      dailyScreenshot: '',
      h4Screenshot: '',
      missed: false,
      note: '',
   }
}
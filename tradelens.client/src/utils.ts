import { TRADE_TYPES } from "@/constants.js";

export function getTradePrefix(type: string): string {
    return TRADE_TYPES[type].prefix;
}

export function getTradePrefixedId(id: number, type: string): string {
    return `${getTradePrefix(type)}-${id}`;
}
export const TRADE_JOURNAL_HEADER = [
   {
      title: 'Id',
      align: 'start',
      sortable: true,
      key: 'id',
   },   {
      title: 'Pair',
      align: 'start',
      sortable: true,
      key: 'pair',
   },
   {
      title: 'Type',
      align: 'start',
      sortable: true,
      key: 'type',
   },
   {
      title: 'Result',
      align: 'start',
      sortable: true,
      key: 'result',
   },
   {
      title: 'Profit (%)',
      align: 'start',
      sortable: true,
      key: 'profit',
   },
   {
      title: 'Entry date',
      align: 'start',
      sortable: true,
      key: 'entryDate',
   },
   {
      title: 'Close date',
      align: 'start',
      sortable: true,
      key: 'closeDate',
   },
   {
      title: 'Weekly Last Candle Close',
      align: 'start',
      sortable: true,
      key: 'weeklyLastCandleClose',
   },
   {
      title: 'Weekly supply and demand',
      align: 'start',
      sortable: true,
      key: 'weeklySupplyAndDemand',
   },
   {
      title: 'Weekly Market structure',
      align: 'start',
      sortable: true,
      key: 'weeklyMarketStructure',
   },
   {
      title: 'Weekly Fibonacci',
      align: 'start',
      sortable: true,
      key: 'weeklyFibonacci',
   },
   {
      title: 'Daily Pattern',
      align: 'start',
      sortable: true,
      key: 'dailyPattern',
   },
   {
      title: 'H4 Pattern',
      align: 'start',
      sortable: true,
      key: 'h4Pattern',
   },
   
   {
      title: 'Weekly Screenshot',
      align: 'start',
      sortable: true,
      key: 'weeklyScreenshot',
   },
   {
      title: 'Daily Screenshot',
      align: 'start',
      sortable: true,
      key: 'dailyScreenshot',
   },
   {
      title: 'H4 Screenshot',
      align: 'start',
      sortable: true,
      key: 'h4Screenshot',
   },
   {
      title: 'Missed',
      align: 'start',
      sortable: true,
      key: 'missed',
   },
   {
      title: 'Note',
      align: 'start',
      sortable: true,
      key: 'note',
   },
]

export const TRADE_TYPES = {
   Trade: {
      name: 'Trade',
      color: 'green',
      prefix: 'T',
   },
   BackTest: {
      name: 'BackTest',
      color: 'blue',
      prefix: 'B',
   }
}

export const RESULT_TYPES = {
   Win: {
      name: 'Win',
      color: 'green',
   },
   Loss: {
      name: 'Loss',
      color: 'red',
   },
   BE: {
      name: 'BE',
      color: 'yellow',
   }
}

export const CURRENCY_PAIR = {
   AUDCAD: 'AUDCAD',
   AUDCHF: 'AUDCHF',
   AUDJPY: 'AUDJPY',
   AUDNZD: 'AUDNZD',
   AUDUSD: 'AUDUSD',
   CADCHF: 'CADCHF',
   CADJPY: 'CADJPY',
   CHFJPY: 'CHFJPY',
   EURAUD: 'EURAUD',
   EURCAD: 'EURCAD',
   EURCHF: 'EURCHF',
   EURGBP: 'EURGBP',
   EURJPY: 'EURJPY',
   EURNZD: 'EURNZD',
   EURUSD: 'EURUSD',
   GBPAUD: 'GBPAUD',
   GBPCAD: 'GBPCAD',
   GBPCHF: 'GBPCHF',
   GBPJPY: 'GBPJPY',
   GBPNZD: 'GBPNZD',
   GBPUSD: 'GBPUSD',
   NZDCAD: 'NZDCAD',
   NZDCHF: 'NZDCHF',
   NZDJPY: 'NZDJPY',
   NZDUSD: 'NZDUSD',
   USDCAD: 'USDCAD',
   USDCHF: 'USDCHF',
   USDJPY: 'USDJPY',
   USDZAR: 'USDZAR',
   USOIL: 'USOIL',
   XAGUSD: 'XAGUSD',
   XAUUSD: 'XAUUSD',
}

export const DAILY_PATTERN = {
   BM1: {
      value: 'BM1',
      label: 'BM1',
   },
   BM2: {
      value: 'BM2',
      label: 'BM2',
   },
   BM3: {
      value: 'BM3',
      label: 'BM3',
   },
   BM4: {
      value: 'BM4',
      label: 'BM4',
   },
   BW1: {
      value: 'BW1',
      label: 'BW1',
   },
   BW2: {
      value: 'BW2',
      label: 'BW2',
   },
   BW3: {
      value: 'BW3',
      label: 'BW3',
   },
   BW4: {
      value: 'BW4',
      label: 'BW4',
   },
   HS: {
      value: 'HS',
      label: 'Head and shoulder',
   },
   InverseHS: {
      value: 'InverseHS',
      label: 'Inverse head and shoulder',
   },
   SmallPatternWithinPattern: {
      value: 'SmallPatternWithinPattern',
      label: 'Small pattern within pattern',
   },
   BigPatternWithinPattern: {
      value: 'BigPatternWithinPattern',
      label: 'Big pattern within pattern',
   },
   Fakeout: {
      value: 'Fakeout',
      label: 'Fakeout',
   },
   HedgePosition: {
      value: 'HedgePosition',
      label: 'Hedge position',
   },
}

export const H4_PATTERN = {
   Deceleration: {
      value: 'Deceleration',
      label: 'Deceleration',
   },
   ThreeLegFibCompletion: {
      value: 'ThreeLegFibCompletion',
      label: 'Three leg fib completion',
   },
   FiveLegFibCompletion: {
      value: 'FiveLegFibCompletion',
      label: 'Five leg fib completion',
   },
   BMWithBOS: {
      value: 'BMWithBOS',
      label: 'BM with BOS',
   },
   BMWithoutBOS: {
      value: 'BMWithoutBOS',
      label: 'BM without BOS',
   },
   BWWithBOS: {
      value: 'BWWithBOS',
      label: 'BW with BOS',
   },
   BWWithoutBOS: {
      value: 'BWWithoutBOS',
      label: 'BW without BOS',
   },
   HSWithBOS: {
      value: 'HSWithBOS',
      label: 'HS with BOS',
   },
   HSWithoutBOS: {
      value: 'HSWithoutBOS',
      label: 'HS without BOS',
   },
   InverseHSWithBOS: {
      value: 'InverseHSWithBOS',
      label: 'Inverse HS with BOS',
   },
   InverseHSWithoutBOS: {
      value: 'InverseHSWithoutBOS',
      label: 'Inverse HS without BOS',
   }
}
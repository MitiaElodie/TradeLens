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
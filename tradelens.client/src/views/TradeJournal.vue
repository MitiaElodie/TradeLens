
<script lang="ts">
import { getTrades } from '@/api/tradeApi.js';
import { getTradePrefixedId } from '@/utils.js';
import { TRADE_JOURNAL_HEADER } from '@/constants.js';
import AddTradeDialog from '@/components/trades/AddTradeDialog.vue';

export default {
   components: {
      AddTradeDialog,
   },

   data() {
      return {
         loading: false,
         trades: [],
         TRADE_JOURNAL_HEADER,
      };
   },

   created() {
      this.fetchData();
   },

   methods: {
      getTradePrefixedId,
      fetchData(): void {
         this.loading = true;

         getTrades()
            .then(trades => {
               console.log(trades)
               this.trades = trades;
            })
            .finally(() => {
               this.loading = false;
            });
      }
   },
};
</script>

<template>
<div class="trade-journal">
   <div class="trade-journal__header-container d-flex ga-4 align-center">
      <h1 class="trade-journal__title">Trade journal</h1>
      <AddTradeDialog />
   </div>
   <v-data-table
      :headers="TRADE_JOURNAL_HEADER"
      :items="trades"
   >
      <template v-slot:[`item.id`]="{ item }">
        {{ getTradePrefixedId(item.id, item.type) }}
      </template>
      <template v-slot:[`item.pair`]="{ item }">
        <v-chip
         prepend-icon="mdi-currency-usd"
         size="small"
         dark>
          {{ item.pair }}
        </v-chip>
      </template>
   </v-data-table>
</div>
</template>
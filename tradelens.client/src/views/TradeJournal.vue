
<script lang="ts">
import { getTrades } from '@/api/tradeLensApi';
import { TRADE_JOURNAL_HEADER } from '@/constants.js';
export default {
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
   <h1 class="trade-journal__title">Trade journal</h1>
   <v-data-table
      :headers="TRADE_JOURNAL_HEADER"
      :items="trades"
   >
      <template v-slot:[`item.pair`]="{ item }">
        <v-chip dark>
          {{ item.pair }}
        </v-chip>
      </template>
   </v-data-table>
</div>
</template>

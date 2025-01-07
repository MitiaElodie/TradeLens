<script lang="ts">
import MultiselectTradeType from '@/components/multiselect/MultiselectTradeType.vue';
import MultiselectCurrencyPair from '@/components/multiselect/MultiselectCurrencyPair.vue';
import MultiselectResultType from '@/components/multiselect/MultiselectResultType.vue';

export default {
   name: 'AddTradeDialog',
   components: {
      MultiselectTradeType,
      MultiselectCurrencyPair,
      MultiselectResultType,
   },

   data() {
      return {
         trade: {
            type: '',
            pair: '',
            result: '',
            weeklyLastCandleClose: false,
            weeklySupplyAndDemand: false,
            weeklyMarketStructure: false,
            weeklyFibonacci: false,
         },
      };
   },
}
</script>

<template>
   <v-dialog max-width="500">
      <template v-slot:activator="{ props: activatorProps }">
         <v-btn
            v-bind="activatorProps"
            text="Add a trade"
         ></v-btn>
      </template>

      <template v-slot:default="{ isActive }">
         <v-card title="Dialog">
            <v-card-text>
               <MultiselectTradeType
                  v-model="trade.type"
               />
               <MultiselectCurrencyPair
                  v-model="trade.pair"
               />
               <MultiselectResultType
                  v-model="trade.result"
               />
               <v-checkbox
                  label="Weekly last candle close"
                  v-model="trade.weeklyLastCandleClose"
               ></v-checkbox>
               <v-checkbox
                  label="Weekly supply and demand"
                  v-model="trade.weeklySupplyAndDemand"
               ></v-checkbox>
               <v-checkbox
                  label="Weekly market structure"
                  v-model="trade.weeklyMarketStructure"
               ></v-checkbox>
               <v-checkbox
                  label="Weekly fibonacci"
                  v-model="trade.weeklyFibonacci"
               ></v-checkbox>
            </v-card-text>

            <v-card-actions>
            <v-spacer></v-spacer>

            <v-btn
               text="Close Dialog"
               @click="isActive.value = false"
            ></v-btn>
            </v-card-actions>
         </v-card>
      </template>
      </v-dialog>
</template>
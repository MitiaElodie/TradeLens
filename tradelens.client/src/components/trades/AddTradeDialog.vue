<script lang="ts">
import MultiselectTradeType from '@/components/multiselect/MultiselectTradeType.vue';
import MultiselectCurrencyPair from '@/components/multiselect/MultiselectCurrencyPair.vue';
import MultiselectResultType from '@/components/multiselect/MultiselectResultType.vue';
import MultiselectDailyPattern from '@/components/multiselect/MultiselectDailyPattern.vue';
import MultiselectH4Pattern from '@/components/multiselect/MultiselectH4Pattern.vue';
import DateAndTimePicker from '@/components/forms/DateAndTimePicker.vue';
import { getEmptyTrade } from '@/utils.js';
import * as tradeApi from '@/api/tradeApi.js';

export default {
   name: 'AddTradeDialog',
   components: {
      MultiselectTradeType,
      MultiselectCurrencyPair,
      MultiselectResultType,
      MultiselectDailyPattern,
      MultiselectH4Pattern,
      DateAndTimePicker,
   },

   data() {
      return {
         trade: getEmptyTrade(),
         isDialogOpen: false,
         isAdding: false,
      };
   },

   methods: {
      addTrade(): void {
         this.isAdding = true;
         tradeApi.addTrade(this.trade)
            .then(() => {
               this.$emit('trade-added');
               this.closeDialog();
            })
            .finally(() => {
               this.isAdding = false;
            });
      },

      closeDialog(): void {
         this.isDialogOpen = false;
      },
   }
}
</script>

<template>
   <v-dialog
      v-model="isDialogOpen"
      max-width="500"
      scrollable
   >
      <template v-slot:activator="{ props: activatorProps }">
         <v-btn
            v-bind="activatorProps"
            text="Add a trade"
         ></v-btn>
      </template>

      <template v-slot:default>
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
               <DateAndTimePicker
                  v-model="trade.entryDate"
                  label="Entry date and time"
               />
               <DateAndTimePicker
                  v-model="trade.closeDate"
                  label="Close date and time"
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
               <MultiselectDailyPattern
                  v-model="trade.dailyPattern"
               />
               <MultiselectH4Pattern
                  v-model="trade.h4Pattern"
               />
               <v-text-field
                  label="Weekly screenshot"
                  v-model="trade.weeklyScreenshot"   
               ></v-text-field>
               <v-text-field
                  label="Daily screenshot"
                  v-model="trade.dailyScreenshot"
               ></v-text-field>
               <v-text-field
                  label="H4 screenshot"
                  v-model="trade.h4Screenshot"
               ></v-text-field>
               <v-checkbox
                  label="Missed"
                  v-model="trade.missed"
               ></v-checkbox>
               <v-text-field
                  label="Profit (%)"
                  v-model="trade.profit"
               />
               <v-textarea
                  label="Note"
                  v-model="trade.note"
               />
            </v-card-text>

            <v-card-actions>
            <v-spacer></v-spacer>
               <v-btn
                  :disabled="isAdding"
                  text="Cancel"
                  @click="closeDialog"
               />
               <v-btn
                  :loading="isAdding"
                  color="primary"
                  text="Add"
                  @click="addTrade"
               />
            </v-card-actions>
         </v-card>
      </template>
      </v-dialog>
</template>
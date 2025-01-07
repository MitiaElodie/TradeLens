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
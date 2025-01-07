<script lang="ts">
import { TRADE_TYPES } from '@/constants.js';
export default {
   name: 'MultiselectTradeType',

   props: {
      value: {
         type: String,
         required: true,
      },
   },

   computed: {
      tradeTypes(): string[] {
         return Object.values(TRADE_TYPES).map(type => type.name);
      },
   },
}
</script>
<template>
   <v-autocomplete
      label="Type"
      :items="tradeTypes"
   ></v-autocomplete>
</template>
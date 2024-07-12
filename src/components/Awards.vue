<template>
    <div class="lighten-2">
      <v-container>
        <template v-for="(value,key,index) in std_cat" >
          <div :key="index" v-if="key == 'Awards'">
            <v-row>
              <div class="mt-2 mb-2">
                <h1 class="mb-4">{{ key }}</h1>
                <p v-for="(pastlab,idx) in value" :key="`${key}${idx}`" style="line-height:13px; ">
                  <a v-if="pastlab['homepage'] != None" :href="pastlab['homepage']">
                    <b>
                      {{pastlab['name']}}
                    </b>
                  </a>
                  <b v-else>
                    · {{pastlab['name']}} &nbsp;
                  </b>
                  <span>{{pastlab['award']}}</span>
                  <!-- <i>{{pastlab['affiliation']}}</i> -->
                </p>
              </div>
            </v-row>
          </div>
          <div :key="index" v-if="key == 'Media'">
            <v-row>
              <div class="mt-2 mb-2">
                <h1 class="mb-4">{{ key }}</h1>
                <p v-for="(reportlab,idx) in value" :key="`${key}${idx}`" style="line-height:13px; ">
                  <a v-if="reportlab['link'] != None" :href="reportlab['link']">
                    <b>
                      {{reportlab['name']}}
                    </b>
                  </a>
                  <b v-else>
                    {{reportlab['name']}}
                  </b>
                  <!-- <span>{{reportlab['link']}}</span> -->
                  <!-- <i>{{reportlab['affiliation']}}</i> -->
                </p>
              </div>
            </v-row>
          </div>
        </template>
      </v-container>
    </div>
</template>

<script>
export default {
  props: ['AwardData'],
  data: () => ({
    std_cat: {},
    cards: ['Awards', 'Media'] // 这里可以加入 Ph.D.以及 Past Members
  }),
  mounted () {
    this.std_cat = this.AwardData
  }
}
</script>

<style>

</style>
